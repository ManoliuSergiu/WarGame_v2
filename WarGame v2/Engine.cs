using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace WarGame_v2
{
	static partial class Engine
	{

        public static TcpListener server;
		public static Random rnd = new Random();
        private static List<TcpClient> clients = new List<TcpClient>();

        public static bool StartServer(IPAddress ip,int port)
        {
            server = new TcpListener(ip, port);
            server.Start();
            ListenForClients();
            return true;
        }

        private async static void ListenForClients()
        {
            while (clients.Count<2)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                clients.Add(client);
                NetworkStream stream = client.GetStream();
                byte[] msg = Encoding.ASCII.GetBytes("0:"+clients.Count);
                stream.Write(msg,0,msg.Length);
            }
        }

        public static byte GetHeight(int x,int y)
		{

			if (Form1.form1.zoomed)
			{
				Point aux = Form1.form1.zoomPoint;
				return zoomedMap[aux.X + x, aux.Y+y ];
			}
			else
				return hMap[x, y];
		}
	}
}
