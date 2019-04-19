using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame_v2
{
	public partial class Form1 : Form
	{
		int maxheight=255;
        readonly int size = 512;
		int offset = 512;
		int waterlevel;
		int minheight = 5;
		public bool zoomed;
		public Point zoomPoint;
		Bitmap map;
		Bitmap zoomedmap;
		public static Form1 form1;
		public static Label loadLabel;
		public Form1()
		{
			InitializeComponent();
			form1 = this;
			loadingLabel.Parent = backgroundPictureBox;
		}

		private async void  Form1_Load(object sender, EventArgs e)
		{
			loadLabel = loadingLabel;
			waterBar.Value = 6;
			smoothnessBar.Value = 12;
			variationBar.Value = 6;
			waterlevel = (int)(maxheight * ((float)waterBar.Value / waterBar.Maximum) / 2 * 0.1f * 10);
			Task<Bitmap> a = Task.Run(() => Engine.GetNewMap(Convert.ToInt32(seedTextBox.Text),alternateStyleCheckBox.Checked, size, minheight, maxheight, waterlevel, offset));
			Bitmap greenscreen = new Bitmap(size+1, size+1);
			Graphics graphics = Graphics.FromImage(greenscreen);
			graphics.Clear(Color.Green);
			backgroundPictureBox.BackgroundImage = greenscreen;
			backgroundPictureBox.Image = map = await a;
			zoomed = false;

		}


		private async void Button1_Click(object sender, EventArgs e)
		{
			Task<Bitmap> a =  Task.Run(() => Engine.GetNewMap(Convert.ToInt32(seedTextBox.Text), alternateStyleCheckBox.Checked, size, minheight, maxheight, waterlevel, offset));
			Bitmap image = await a;
			backgroundPictureBox.Image = map = image;
			zoomed = false;
			backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

		}

		private async void WaterBar_Scroll(object sender, EventArgs e)
		{
			int a;
			TrackBar bar = waterBar;
			a = (int)(maxheight * ((float)bar.Value / bar.Maximum)/2 * 0.1f * 10);
			waterlevel = a;
			if(sender==waterBar) backgroundPictureBox.Image = map = await Task.Run(()=>Engine.DrawMap(alternateStyleCheckBox.Checked,a));
        }

        private void MaxHBar_Scroll(object sender, EventArgs e)
		{
			switch (maxHBar.Value)
			{
				case 0:  maxheight = 50; break;
				case 1:  maxheight = 70; break;
				case 2:  maxheight = 90; break;
				case 3:  maxheight = 110; break;
				case 4:  maxheight = 130; break;
				case 5:  maxheight = 150; break;
				case 6:  maxheight = 170; break;
				case 7:  maxheight = 190; break;
				case 8:  maxheight = 210; break;
				case 9:  maxheight = 230; break;
				case 10: maxheight = 250; break;
				case 11: maxheight = 255; break;
				default: maxheight = 255; break;

			}
			waterlevel=(int)(maxheight * ((float)waterBar.Value / waterBar.Maximum) / 2 * 0.1f * 10);
		}

		private void VariationBar_Scroll(object sender, EventArgs e)
		{
			TrackBar bar = variationBar;
			offset = (int)(512 * ((float) bar.Value / (bar.Maximum)));
		}

		private void SmoothnessBar_Scroll(object sender, EventArgs e)
		{
			TrackBar bar = smoothnessBar;
			minheight = (int)(20 * ((float)(bar.Maximum-bar.Value) / (bar.Maximum)) +5);
		
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			DisposeFirstStageUi();

		}

		private void DisposeFirstStageUi()
		{
			generateMapButton.Dispose();
			button2.Dispose();
			maxHeightGroup.Dispose();
			minHeightGroup.Dispose();
			heightVariationGroup.Dispose();
			waterLevelGroup.Dispose();
		}

		private void BackgroundPictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			if(ModifierKeys.HasFlag(Keys.Control))
			{
				if (zoomed)
					Unzoom();
				else
					Zoom(e);

				backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			if (ModifierKeys.HasFlag(Keys.Alt))
			{
				debugLabel.Text = Engine.GetHeight(e.X, e.Y)+" - "+ e.X+"/"+e.Y;
			}
		}

		private void Unzoom()
		{
			zoomedmap = null;
			backgroundPictureBox.Image = map;
			zoomed = false;
		}

		private async void Zoom(MouseEventArgs e)
		{
			zoomPoint = e.Location;
			zoomedmap = new Bitmap(size + 1, size + 1);
			int x = e.X;
			int y = e.Y;
			zoomedmap = await Task.Run(() => Engine.ZoomMap(x, y, alternateStyleCheckBox.Checked, waterlevel));
			backgroundPictureBox.Image = zoomedmap;
			zoomed = true;
		}

		private async void AlternateStyleCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			zoomed = false;
			backgroundPictureBox.Image = map = await Task.Run(() => Engine.DrawMap(alternateStyleCheckBox.Checked, waterlevel));

		}

        private void Button3_Click(object sender, EventArgs e)
        {
            seedTextBox.Text = "" + Engine.rnd.Next(int.MinValue, int.MaxValue);
        }

        private void GenerateRandomMapButton_Click(object sender, EventArgs e)
        {
            RandomizeSettings(sender,e);
            Button1_Click(sender, e);
        }

        private void RandomizeSettings(object sender, EventArgs e)
        {
            Button3_Click(sender, e);
            maxHBar.Value = Engine.rnd.Next(maxHBar.Maximum + 1);
            smoothnessBar.Value = Engine.rnd.Next(smoothnessBar.Maximum + 1);
            variationBar.Value = Engine.rnd.Next(variationBar.Maximum + 1);
            waterBar.Value = Engine.rnd.Next(waterBar.Maximum + 1);
            MaxHBar_Scroll(sender, e);
            VariationBar_Scroll(sender, e);
            SmoothnessBar_Scroll(sender, e);
            WaterBar_Scroll(sender, e);
        }
    }
}
