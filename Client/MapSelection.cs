using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MapSelection : Form
    {
        public static PictureBox bgPictureBox; 
        public static MapSelection form;
        public static Button acceptMapButton;
        private static GroupBox mapSelectionGB;
        public static bool style = false;
        public MapSelection(bool online)
        {
            InitializeComponent();
            Engine.online = online;
            if (online)
            {
                OnlineLoad();
            }
            else
            {
                OfflineLoad();
            }
        }
        private void MapSelection_Load(object sender, EventArgs e)
        {
            bgPictureBox = backgroundPictureBox;
            mapSelectionGB = mapSelectionGroup;
            acceptMapButton = button2;
            form = this;
            mapSelectionGB.Visible = true;
            Bitmap greenscreen = new Bitmap(Engine.size + 1, Engine.size + 1);
            Graphics graphics = Graphics.FromImage(greenscreen);
            graphics.Clear(Color.Green);
            backgroundPictureBox.BackgroundImage = greenscreen;
            waterBar.MouseUp += WaterBar_MouseUp;
            waterBar.KeyUp += WaterBar_KeyUp;
        }
        private void WaterBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                WaterBar_Scroll(sender, e);

        }

        private void WaterBar_MouseUp(object sender, MouseEventArgs e)
        {
            WaterBar_Scroll(sender, e);
        }
        private void OnlineLoad()
        {
            modeLabel.Text = "Multiplayer";
        }

        private async void OfflineLoad()
        {
            modeLabel.Text = "Singleplayer";
            backgroundPictureBox.Image = await Task.Run(()=>Engine.GetNewMap(Engine.rnd.Next(int.MinValue,int.MaxValue)));
        }
        private void SmoothnessBar_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = smoothnessBar;
            Engine.minheight = (int)(20 * ((float)(bar.Maximum - bar.Value) / (bar.Maximum)) + 5);

        }

        private void MaxHBar_Scroll(object sender, EventArgs e)
        {
            switch (maxHBar.Value)
            {
                case 0:  Engine.maxheight = 50; break;
                case 1:  Engine.maxheight = 70; break;
                case 2:  Engine.maxheight = 90; break;
                case 3:  Engine.maxheight = 110; break;
                case 4:  Engine.maxheight = 150; break;
                case 6:  Engine.maxheight = 170; break;
                case 7:  Engine.maxheight = 190; break;
                case 8:  Engine.maxheight = 210; break;
                case 9:  Engine.maxheight = 230; break;
                case 10: Engine.maxheight = 250; break;
                case 11: Engine.maxheight = 255; break;
                default: Engine.maxheight = 255; break;

            }
            Engine.waterlevel = (int)(Engine.maxheight * ((float)waterBar.Value / waterBar.Maximum) / 2 * 0.1f * 10);
        }

        private void VariationBar_Scroll(object sender, EventArgs e)
        {
            TrackBar bar = variationBar;
            Engine.offset = (int)(512 * ((float)bar.Value / (bar.Maximum)));
        }

        private async void WaterBar_Scroll(object sender, EventArgs e)
        {
            int a;
            TrackBar bar = waterBar;
            a = (int)(Engine.maxheight * ((float)bar.Value / bar.Maximum) / 2 * 0.1f * 10);
            Engine.waterlevel = a;
            if (sender == waterBar)
            {
                if(Engine.online) Engine.SendString("MapGeneration" + Engine.mainSeparator[0] + Convert.ToInt32(seedTextBox.Text) + Engine.secondarySeparator[0] + Engine.size + Engine.secondarySeparator[0] + Engine.minheight + Engine.secondarySeparator[0] + Engine.maxheight + Engine.secondarySeparator[0] + Engine.waterlevel + Engine.secondarySeparator[0] + Engine.offset);
                else backgroundPictureBox.Image = await Task.Run(() => Engine.DrawMap(a));

            }
        }

        private async void AlternateStyleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            style = alternateStyleCheckBox.Checked;
            backgroundPictureBox.Image = await Task.Run(() => Engine.DrawMap(Engine.waterlevel));

        }
        public void GenerateRandomMapButton_Click(object sender, EventArgs e)
        {
            RandomizeSettings(sender, e);
            GenerateMapButton_Click(sender, e);
        }

        private void RandomizeSettings(object sender, EventArgs e)
        {
            RandomSeedButton_Click(sender, e);
            maxHBar.Value = Engine.rnd.Next(maxHBar.Maximum + 1);
            smoothnessBar.Value = Engine.rnd.Next(smoothnessBar.Maximum + 1);
            variationBar.Value = Engine.rnd.Next(variationBar.Maximum + 1);
            waterBar.Value = Engine.rnd.Next(waterBar.Maximum + 1);
            MaxHBar_Scroll(sender, e);
            VariationBar_Scroll(sender, e);
            SmoothnessBar_Scroll(sender, e);
            WaterBar_Scroll(sender, e);
        }

        private async void GenerateMapButton_Click(object sender, EventArgs e)
        {
            if(Engine.online) Engine.SendString("MapGeneration" + Engine.mainSeparator[0] + Convert.ToInt32(seedTextBox.Text) + Engine.secondarySeparator[0] + Engine.size + Engine.secondarySeparator[0] + Engine.minheight + Engine.secondarySeparator[0] + Engine.maxheight + Engine.secondarySeparator[0] + Engine.waterlevel + Engine.secondarySeparator[0] + Engine.offset); 
            else
            {
                Bitmap image = await Task.Run(() => Engine.GetNewMap(Convert.ToInt32(seedTextBox.Text), Engine.size, Engine.minheight, Engine.maxheight, Engine.waterlevel, Engine.offset));
                backgroundPictureBox.Image = image;
                backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void RandomSeedButton_Click(object sender, EventArgs e)
        {
            seedTextBox.Text = "" + Engine.rnd.Next(int.MinValue, int.MaxValue);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Engine.online)
            {
                Engine.PlayerAcceptMap();
                button2.Enabled = false;
            }
            else
            {
                UnitSelectionPhase();
            }
        }
        public static void UnitSelectionPhase()
        {
            mapSelectionGB.Invoke((MethodInvoker)(() => mapSelectionGB.Visible = false));
        }

    }
}
