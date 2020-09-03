using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class MessageRequest
    {
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string Message { get; set; }
    }
}
