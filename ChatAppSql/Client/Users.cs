using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
using Server.Models;

namespace Client
{
    public partial class Users : Form
    {
        byte[] receivedBuf = new byte[1024];
        private Socket _clientSocket;
        Repository repository = new Repository();
        public static string userName;
        public static string receiverName;

        public Users()
        {
            InitializeComponent();
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            CheckForIllegalCrossThreadCalls = false;
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

        private void ConnectToServer()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Parse("127.0.0.1"), 100);
                }
                catch (SocketException se)
                {
                    throw new Exception(se.Message);
                }
            }
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            repository.LogOut(userName);
            byte[] buffer = Encoding.ASCII.GetBytes("Disconnect");
            _clientSocket.Send(buffer);
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)
            {
                string user = string.Empty;
                string userNamee = string.Empty;
                string msg = string.Empty;
                for (int i = 0; i < listUsers.SelectedItems.Count; i++)
                {
                    userNamee = listUsers.SelectedItems[i].ToString();
                }
                if (userNamee.Length != 0)
                {
                    user = "#" + userNamee + " : ";
                    msg = user + textMessage.TextName;
                }
                else
                {
                    msg = textMessage.TextName;
                }
                byte[] buffer = Encoding.ASCII.GetBytes(msg);
                _clientSocket.Send(buffer);
                richTextMessage.AppendText("You: " + textMessage.TextName + "\n");
                textMessage.TextName = "";
            }
        }

        public void SetUserName(string username)
        {
            userName = username;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            ConnectToServer();
            richTextMessage.ReadOnly = true;
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            byte[] buffer = Encoding.ASCII.GetBytes("@" + userName);
            _clientSocket.Send(buffer);
        }


        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int received = socket.EndReceive(ar);
            byte[] dataBuf = new byte[received];
            Array.Copy(receivedBuf, dataBuf, received);
            string serverMsg = (Encoding.ASCII.GetString(dataBuf));

            if (serverMsg.Contains("@"))
            {
                listUsers.Items.Add(serverMsg.TrimStart('@'));
            }
            else
                richTextMessage.AppendText(serverMsg + "\n");
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listUsers.SelectedItems.Count; i++)
            {
                receiverName = listUsers.SelectedItems[i].ToString();
            }
            List<MessageRequest> userMessages =  repository.GetUserMessagesByReceiverName(userName, receiverName);
            for(int j=0; j<userMessages.Count; j++)
            {
                if (userMessages[j].SenderName == userName)
                    richTextMessage.AppendText("You: " + userMessages[j].Message + "\n");
                else 
                    richTextMessage.AppendText(receiverName + ": " + userMessages[j].Message + "\n");
            }

        }
    }
}
