using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client
{
    public static partial class Engine
    {
        private static TcpClient client;
        private static Queue<string> stringsToInterpret = new Queue<string>();
        public static char[] messageSeparator = { '~' };
        public static char[] mainSeparator = { '|' };
        public static char[] secondarySeparator = { '$' };
        public static sbyte team = -1; //true = blue, false = red
        public static bool enemyReady = false;
        public static bool playerReady = false;
        public static Random rnd = new Random();
        public static bool online;

        internal static bool ConnectToServer(IPAddress ip, int port)
        {
            client = new TcpClient();
            try
            {
                client.Connect(ip, port);
                NetworkStream stream = client.GetStream();
                Task.Run(()=>Listen(stream));
                return true;
            }
        
            catch (Exception)
            {

                return false;
            } 
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
                    Debug.WriteLine("Server recieved: " + data);
                }
                while (stringsToInterpret.Count != 0)
                {
                    InterpretString(stringsToInterpret.Dequeue());
                }
            }
        }

        public static void SendString(string data)
        {
            byte[] msg = Encoding.ASCII.GetBytes(data+ messageSeparator[0]);
            client.GetStream().Write(msg, 0, msg.Length);
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
                        case "Initialization":
                            team = Convert.ToSByte(splitdata[1]);
                            break;
                        case "MapGeneration":
                            MapSelection.bgPictureBox.Image = GetNewMap(splitdata[1]);
                            break;
                        case "WaterLevelChange":
                            if (hMap != null) MapSelection.bgPictureBox.Image = DrawMap(splitdata[1]);
                            break;
                        case "PlayerAccept":
                            EnemyAcceptMap();
                            break;
                        default:
                            MessageBox.Show("This shouldn't have happened...the " + splitdata[0] + " command could not be interpreted so it's probably a server side error.", "Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }

        private static void EnemyAcceptMap()
        {
            enemyReady = true;
            if (playerReady)
            {
                MapSelection.UnitSelectionPhase();
            }
        }
        public static void PlayerAcceptMap()
        {
            playerReady = true;
            if (enemyReady)
            {
                MapSelection.UnitSelectionPhase();
            }
            SendString("PlayerAccept" + mainSeparator[0] + team);
        }

    }
}
