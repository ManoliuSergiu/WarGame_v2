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
		int size = 512;
		int offset = 120;
		int waterlevel;
		int minheight = 5;
		bool zoomed;
		Bitmap map;
		Bitmap zoomedmap;
		public static Form1 form1;
		public Form1()
		{
			InitializeComponent();
			form1 = this;
		}

		private async void  Form1_Load(object sender, EventArgs e)
		{
			trackBar1.Value = 6;
			trackBar4.Value = 12;
			trackBar3.Value = 6;
			waterlevel = (int)(maxheight * ((float)trackBar1.Value / trackBar1.Maximum) / 2 * 0.1f * 10);
			Bitmap greenscreen = new Bitmap(size+1, size+1);
			Graphics graphics = Graphics.FromImage(greenscreen);
			graphics.Clear(Color.Green);

			backgroundPictureBox.BackgroundImage = greenscreen;
			backgroundPictureBox.Image = map = await Engine.GetNewMap();
			zoomed = false;
		}


		private async void button1_Click(object sender, EventArgs e)
		{
			Bitmap image = await Engine.GetNewMap(alternateStyleCheckBox.Checked,size,minheight,maxheight,waterlevel,offset);
			backgroundPictureBox.Image = map = image;
			backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			int a;
			TrackBar aux = (TrackBar)sender;
			a = (int)(maxheight * ((float)aux.Value / aux.Maximum)/2 * 0.1f * 10);
			waterlevel = a;
			backgroundPictureBox.Image = map = Engine.DrawMap(alternateStyleCheckBox.Checked,a).Result;
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			TrackBar aux = (TrackBar)sender;
			switch (aux.Value)
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
			waterlevel=(int)(maxheight * ((float)trackBar1.Value / trackBar1.Maximum) / 2 * 0.1f * 10);
		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			switch (((TrackBar)sender).Value)
			{ 
				case 0:  offset = 1;  break;
				case 1:  offset = 30;  break;
				case 2:  offset = 50;  break;
				case 3:  offset = 80;  break;
				case 4:  offset = 110; break;
				case 5:  offset = 140; break;
				case 6:  offset = 170; break;
				case 7:  offset = 200; break;
				case 8:  offset = 230; break;
				case 9:  offset = 255; break;
				default: offset = 255; break;
			}
		}

		private void trackBar4_Scroll(object sender, EventArgs e)
		{
			TrackBar bar = (TrackBar)sender;
			minheight = (int)(20 * ((float)(bar.Maximum-bar.Value) / (bar.Maximum)) +5);
		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DisposeFirstStageUi();

		}

		private void DisposeFirstStageUi()
		{
			button1.Dispose();
			button2.Dispose();
			maxHeightGroup.Dispose();
			minHeightGroup.Dispose();
			heightVariationGroup.Dispose();
			waterLevelGroup.Dispose();
		}

		private void backgroundPictureBox_MouseClick(object sender, MouseEventArgs e)
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
				debugLabel.Text = Engine.GetHeight(e.X, e.Y)+"";
			}
		}

		private void Unzoom()
		{
			zoomedmap = null;
			backgroundPictureBox.Image = map;
			zoomed = false;
		}

		private void Zoom(MouseEventArgs e)
		{
			zoomedmap = new Bitmap(size + 1, size + 1);
			Graphics gfx = Graphics.FromImage(zoomedmap);
			int x = 0;
			int y;
			if (e.X - size / 4 < 0)
			{
				x = 0;
			}
			else
			{
				if (e.X + size / 4 > size + 1)
				{
					x = size / 2;
				}
				else
				{
					x = e.X - size / 4;
				}
			}
			if (e.Y - size / 4 < 0)
			{
				y = 0;
			}
			else
			{
				if (e.Y + size / 4 > size + 1)
				{
					y = size / 2;
				}
				else
				{
					y = e.Y - size / 4;
				}
			}
			gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			gfx.DrawImage(map, new Rectangle(0, 0, size + 1, size + 1), new Rectangle(x, y, zoomedmap.Size.Width / 2, zoomedmap.Size.Height / 2), GraphicsUnit.Pixel);
			backgroundPictureBox.Image = zoomedmap;
			zoomed = true;
		}

		private void alternateStyleCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			backgroundPictureBox.Image = map = Engine.DrawMap(alternateStyleCheckBox.Checked, waterlevel).Result;

		}
	}
}
