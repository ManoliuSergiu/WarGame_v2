using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace Client
{
    public static partial class Engine
    {
        private static TcpClient client;
        public static char[] mainSeparator = { ':' };
        public static char[] secondarySeparator = { '|' };
        public static bool team; //true = blue, false = red
        public static Random rnd = new Random();
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
                    InterpretString(data);
                    Debug.WriteLine(data);
                }
            }
        }

        public static void SendString(string data)
        {
            byte[] msg = Encoding.ASCII.GetBytes(data);
            client.GetStream().Write(msg, 0, msg.Length);
        }

        private static void InterpretString(string data)
        {
            string[] splitdata = data.Split(mainSeparator, StringSplitOptions.RemoveEmptyEntries);
            {
                switch (splitdata[0])
                {
                    case "Initialization":
                        if (splitdata[1] == "1") team = true;
                        else team = false;
                        break;
                    case "MapGeneration":
                        MapSelection.bgPictureBox.Image = GetNewMap(splitdata[1]);
                        break;
                    case "WaterLevelChange":
                        if (hMap != null) MapSelection.bgPictureBox.Image = DrawMap(splitdata[1]);
                        break;

                    default:
                        break;
                }
            }
        }


    }
}
