using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Drawing;

namespace Client
{
    public static partial class Engine
    {
        private static TcpClient client;
        public static char[] mainSeparator = { ':' };
        public static char[] secondarySeparator = { '|' };
        public static bool team; //true = blue, false = red
        internal static bool ConnectToServer(IPAddress ip, int port)
        {
            client = new TcpClient();
            client.Connect(ip, port);
            NetworkStream stream = client.GetStream();
            Task.Run(()=>Listen(stream));
            return true;
        }

        private static void Listen(NetworkStream stream)
        {
            while (true)
            {

                Byte[] bytes = new Byte[256];
                string data = null;
                int i = stream.Read(bytes, 0, bytes.Length);
                data = Encoding.ASCII.GetString(bytes, 0, i);
                if (i != 0)
                {
                    InterpretString(data);
                    ConnectionForm.form.Invoke(new Action(() => ConnectionForm.label.Text = data));
                }
            }
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
                        ConnectionForm.ChangeMap(GetNewMap(splitdata[1]));
                        break;
                    default:
                        break;
                }
            }
        }

        private static Bitmap GetNewMap(string v)
        {
            string[] mapSettings = v.Split(secondarySeparator);

            size =       Convert.ToInt32(mapSettings[1]);
            minheight =  Convert.ToInt32(mapSettings[2]);
            minheight =  Convert.ToInt32(mapSettings[3]);
            waterlevel = Convert.ToInt32(mapSettings[4]);
            offset =     Convert.ToInt32(mapSettings[5]);

            return GetNewMap(Convert.ToInt32(mapSettings[0]), Convert.ToInt32(mapSettings[1]), 
                             Convert.ToInt32(mapSettings[2]), Convert.ToInt32(mapSettings[3]), 
                             Convert.ToInt32(mapSettings[4]), Convert.ToInt32(mapSettings[5]));


        }
    }
}
