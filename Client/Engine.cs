using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    public static partial class Engine
    {
        private static TcpClient client;
        internal static bool ConnectToServer(IPAddress ip, int port)
        {
            client = new TcpClient();
            client.Connect(ip, port);
            NetworkStream stream = client.GetStream();
            Byte[] bytes = new Byte[256];
            string data = null;
            int i = stream.Read(bytes, 0, bytes.Length);
            data = Encoding.ASCII.GetString(bytes, 0, i);
            ConnectionForm.label.Text = data;
            return true;
        }
    }
}
