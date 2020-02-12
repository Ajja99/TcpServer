using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServer
{
    public class ExtendedTcpClient : TcpClient
    {
        public string Username { get; set; }
    }
}
