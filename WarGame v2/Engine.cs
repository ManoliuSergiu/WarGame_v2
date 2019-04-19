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

        public static bool StartServer(IPAddress ip,int port)
        {
            server = new TcpListener(ip, port);
            server.Start();
            return true;
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
