using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Client
{
    public partial class ConnectionForm : Form
    {
        public static Label label;
        public static ConnectionForm form;
        public static Bitmap map;       //To Be removed
        public static PictureBox pb;    //To Be removed
        readonly int size = 512;        //To Be removed
        public static bool style = false;
        public ConnectionForm()
        {
            InitializeComponent();
            form = this;
            label = label1;
            LoadSt();//To Be removed
            
        }

        private void LoadSt()
        {
            Bitmap greenscreen = new Bitmap(size + 1, size + 1);
            Graphics graphics = Graphics.FromImage(greenscreen);
            graphics.Clear(Color.Green);
            backgroundPictureBox.BackgroundImage = greenscreen;
            pb = backgroundPictureBox;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(portTextBox.Text, out int result))
            {
                if (IPAddress.TryParse(ipTextbox.Text, out IPAddress ip))
                {
                    bool check = Engine.ConnectToServer(ip, result);
                    if (check)
                    {
                        serverStatusLabel.Text = "ok";
                    }
                }
                else
                {
                    ipTextbox.Text = "Invalid IP";
                }
            }
            else
            {
                portTextBox.Text = "Invalid Port";
            }
        }

        internal static void ChangeMap(Bitmap bitmap)
        {
            map = bitmap;
            pb.Image = map;
        }

        private async void AlternateStyleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            style = alternateStyleCheckBox.Checked;
            backgroundPictureBox.Image = map = await Task.Run(() => Engine.DrawMap(Engine.waterlevel));
        }
    }
}
