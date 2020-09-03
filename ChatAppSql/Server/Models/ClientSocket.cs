using System.Net.Sockets;

namespace Server.Models
{
    public class ClientSocket
    {
        public Socket _Socket { get; set; }
        public string _UserName { get; set; }
        public ClientSocket(Socket socket)
        {
            this._Socket = socket;
        }
    }
}
