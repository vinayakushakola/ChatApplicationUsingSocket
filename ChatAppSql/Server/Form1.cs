using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        public List<ClientSocket> _clientSockets { get; set; }
        public List<string> _userNames = new List<string>();
        private byte[] _buffer = new byte[1024];
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private Repository repository = new Repository();
        public FormServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _clientSockets = new List<ClientSocket>();
        }

        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            _serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 100));
            _serverSocket.Listen(20);
            labelStatus.Text = "Server Listening...";
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            Socket clientSocket = _serverSocket.EndAccept(ar);
            _clientSockets.Add(new ClientSocket(clientSocket));
            listUsers.Items.Add(clientSocket.RemoteEndPoint.ToString());
            clientSocket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), clientSocket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            if (socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(ar);
                }
                catch (Exception)
                {
                    for (int i = 0; i < _clientSockets.Count; i++)
                    {
                        if (_clientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            _clientSockets.RemoveAt(i);
                        }
                    }
                    return;
                }
                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);
                    string text = Encoding.ASCII.GetString(dataBuf);
                    int pFrom;
                    string reponse = string.Empty;
                    if (text.Contains("@"))
                    {
                        for (int i = 0; i < listUsers.Items.Count; i++)
                        {
                            if (socket.RemoteEndPoint.ToString().Equals(_clientSockets[i]._Socket.RemoteEndPoint.ToString()))
                            {
                                listUsers.Items.RemoveAt(i);
                                listUsers.Items.Insert(i, text.Substring(1, text.Length - 1));
                                _clientSockets[i]._UserName = text;
                                _userNames.Add(text);
                                for (int j = 0; j < _clientSockets.Count - 1; j++)
                                {
                                    Sendata(_clientSockets[j]._Socket, _clientSockets[i]._UserName);
                                }
                                for (int k = 0; k < _userNames.Count - 1; k++)
                                {
                                    Sendata(socket, _userNames[k]);
                                    Thread.Sleep(1);
                                }
                                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                                return;
                            }
                        }
                    }
                    else if(text == "Disconnect")
                    {
                        Socket disClient = null;
                        for (int i = 0; i < _clientSockets.Count; i++)
                        {
                            if (_clientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                            {
                                disClient = _clientSockets[i]._Socket;
                                _clientSockets.RemoveAt(i);
                                listUsers.Items.RemoveAt(i);
                                _userNames.RemoveAt(i);
                                Close(disClient);
                            }
                        }
                        //disClient.Disconnect(true);
                        //socket.Disconnect(true);
                        //socket.Close();

                    }
                    else if (text.Contains("#"))
                    {
                        pFrom = text.IndexOf(":") + ":".Length;

                        string clientName = text.Substring(1, pFrom - 3);
                        string msg = text.Substring(pFrom - 2);
                        string senderName = string.Empty;
                        for (int j = 0; j < _clientSockets.Count; j++)
                        {
                            if (_clientSockets[j]._Socket == socket)
                            {
                                senderName = _clientSockets[j]._UserName;
                                senderName = senderName.TrimStart('@');
                                break;
                            }
                        }
                        for (int i = 0; i < _clientSockets.Count; i++)
                        {

                            if (clientName == _clientSockets[i]._UserName.TrimStart('@'))
                            {
                                Sendata(_clientSockets[i]._Socket, senderName + msg);
                                richTextMessage.AppendText(senderName + "->" + clientName + msg);
                                MessageRequest message = new MessageRequest
                                {
                                    SenderName = senderName,
                                    ReceiverName = clientName,
                                    Message = text.Substring(pFrom+1)
                                };
                                repository.AddSentMessageDetails(message);
                                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                                return;
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < _clientSockets.Count; i++)
                        {
                            if (socket.RemoteEndPoint.ToString().Equals(_clientSockets[i]._Socket.RemoteEndPoint.ToString()))
                            {
                                richTextMessage.AppendText("\n" + _clientSockets[i]._UserName.TrimStart('@') + ":" + text);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < _clientSockets.Count; i++)
                    {
                        if (_clientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            _clientSockets.RemoveAt(i);
                        }
                    }
                }
            }
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }
        public void Close(Socket sock)
        {
            sock.Dispose();
            sock.Close();
        }
        void Sendata(Socket socket, string response)
        {
            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

    }
}
