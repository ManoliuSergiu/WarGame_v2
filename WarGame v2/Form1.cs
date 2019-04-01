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
		int offset = 120;
		int waterlevel = 60;
		int minheight = 1;
		public static Form1 form1;
		public Form1()
		{
			InitializeComponent();
			form1 = this;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			trackBar1.Value = 6;
			trackBar4.Value = 0;
			trackBar3.Value = 6;
			label10.Text = ""+waterlevel;
			Bitmap greenscreen = new Bitmap(513, 513);
			Graphics graphics = Graphics.FromImage(greenscreen);
			graphics.Clear(Color.Green);
			
			backgroundPictureBox.BackgroundImage = greenscreen;
			backgroundPictureBox.Image = MapRenderer.GetNewMap();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Bitmap image = MapRenderer.GetNewMap(512,5,maxheight,waterlevel,offset);
			Graphics graphics = Graphics.FromImage(image);
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			backgroundPictureBox.Image = image;
			backgroundPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			int a;
			switch (((TrackBar)sender).Value)
			{
				case 0:  a = 0;   break;
				case 1:  a = 10;  break;
				case 2:  a = 20;  break;
				case 3:  a = 30;  break;
				case 4:  a = 40;  break;
				case 5:  a = 50;  break;
				case 6:  a = 60;  break;
				case 7:  a = 70;  break;
				case 8:  a = 80;  break;
				case 9:  a = 90;  break;
				case 10: a = 100; break;
				case 11: a = 110; break;
				case 12: a = 120; break;
				default: a = 40;  break;
			}
			waterlevel = a;
			label10.Text = "" + waterlevel;
			backgroundPictureBox.Image = MapRenderer.DrawMap(a);
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			switch (((TrackBar)sender).Value)
			{
				case 0:  maxheight = 140; break;
				case 1:  maxheight = 150; break;
				case 2:  maxheight = 161; break;
				case 3:  maxheight = 171; break;
				case 4:  maxheight = 182; break;
				case 5:  maxheight = 192; break;
				case 6:  maxheight = 203; break;
				case 7:  maxheight = 213; break;
				case 8:  maxheight = 224; break;
				case 9:  maxheight = 234; break;
				case 10: maxheight = 245; break;
				case 11: maxheight = 255; break;
				default: maxheight = 255; break;
			}
		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			switch (((TrackBar)sender).Value)
			{ 
				case 0:  offset = 20;  break;
				case 1:  offset = 40;  break;
				case 2:  offset = 60;  break;
				case 3:  offset = 80;  break;
				case 4:  offset = 100; break;
				case 5:  offset = 120; break;
				case 6:  offset = 140; break;
				case 7:  offset = 160; break;
				case 8:  offset = 180; break;
				case 9:  offset = 200; break;
				case 10: offset = 220; break;
				case 11: offset = 240; break;
				case 12: offset = 255; break;
				default: offset = 255; break;
			}
		}

		private void trackBar4_Scroll(object sender, EventArgs e)
		{
			TrackBar bar = (TrackBar)sender;
			minheight = (int)(waterlevel * ((float)bar.Value / bar.Maximum));
		
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
	}
}
