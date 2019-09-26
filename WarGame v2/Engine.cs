using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace WarGame_v2
{
	static partial class Engine
	{

        public static TcpListener server;
		public static Random rnd = new Random();
        private static List<TcpClient> clients = new List<TcpClient>();
        private static Queue<string> stringsToInterpret = new Queue<string>();
        public static char[] messageSeparator = { '~' };
        public static char[] mainSeparator = { '|' };
        public static char[] secondarySeparator = { '$' };
        public static byte acceptCount = 0;
        public static bool StartServer(IPAddress ip,int port)
        {
            server = new TcpListener(ip, port);
            server.Start();
            ListenForClients();
            return true;
        }
        private static void Listen(NetworkStream stream)
        {
            while (true)
            {

                Byte[] bytes = new Byte[256];
                string data;
                int i = stream.Read(bytes, 0, bytes.Length);
                data = Encoding.ASCII.GetString(bytes, 0, i);
                if (i != 0)
                {
                    stringsToInterpret.Enqueue(data);
                    Debug.WriteLine("Server recieved: "+data);

                }
                while (stringsToInterpret.Count!=0)
                {
                    InterpretString(stringsToInterpret.Dequeue());
                }
            }
        }

        private static void InterpretString(string incomingData)
        {
            string[] messages = incomingData.Split(messageSeparator,StringSplitOptions.RemoveEmptyEntries);
            foreach (string message in messages)
            {
                string[] splitdata = message.Split(mainSeparator, StringSplitOptions.RemoveEmptyEntries);
                {
                    switch (splitdata[0])
                    {
                        case "MapGeneration":
                            NewMap(splitdata[1]);
                            break;
                        case "WaterLevelChange":
                            NewMap(splitdata[1]);
                            break;
                        case "PlayerAccept":
                            PlayerAccept(Convert.ToInt32(splitdata[1]));
                            break;
                        default:
                            MessageBox.Show("This shouldn't have happened...the " + splitdata[0] + " command could not be interpreted so it's probably a clientside error.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }

        private static void NewMap(string splitdata)
        {
            acceptCount = 0;
            Form1.bgPictureBox.Image = GetNewMap(splitdata);
        }


        private static void PlayerAccept(int player)
        {
            SendString("PlayerAccept"+mainSeparator[0],(player==0?1:0));
            acceptCount++;
        }

        public static void SendString(string data)
        {
            foreach (TcpClient client in clients)
            {
                byte[] msg = Encoding.ASCII.GetBytes(data+messageSeparator[0]);
                client.GetStream().Write(msg, 0, msg.Length);
            }
        }
        public static void SendString(string data,int index)
        {
            byte[] msg = Encoding.ASCII.GetBytes(data + messageSeparator[0]);
            clients[index].GetStream().Write(msg, 0, msg.Length);
            Debug.WriteLine("Server sends: " + data + "to "+index);

        }


        private async static void ListenForClients()
        {
            while (clients.Count<2)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                clients.Add(client);
                NetworkStream stream = client.GetStream();
                _ = Task.Run(() => Listen(stream));
                SendString("Initialization" + mainSeparator[0] + (clients.Count - 1), (clients.Count - 1));
                Form1.nrconnLabel.Text = clients.Count + "/2 players connected.";
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
