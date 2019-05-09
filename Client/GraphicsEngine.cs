using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client
{
    static partial class Engine
	{
		static byte[,] hMap;
        public static int maxheight = 255;
        public static int size = 512;
        public static int offset = 512;
        public static int waterlevel;
        public static int minheight = 5;

        public static  Bitmap GetNewMap(int seed,int size = 512, int min = 5, int max = 255, int waterLevel = 60, int offset = 120)
		{
			hMap =  DiamondSquareGen.Generate(seed, size, min, max,offset);
			Bitmap result = DrawMap(waterLevel, size);
			return result;
		}

        public static Bitmap DrawMap(string data)
        {
            waterlevel = Convert.ToInt32(data);
            return DrawMap(waterlevel);
           
        }
        public static Bitmap DrawMap(int waterLevel = 60, int size = 512)
        {
            if (hMap != null)
            {
                if (MapSelection.style)
                    return MapStyle2(hMap, waterLevel, size);
                else
                    return MapStyle1(hMap, waterLevel, size);
            }
            return new Bitmap(size+1,size+1);
        }

		private static Bitmap MapStyle2(byte[,] heightMap, int waterLevel, int size, int posX = 0,int posY = 0)
		{
			NormalizeXY(size, ref posX, ref posY);
			Bitmap map = new Bitmap(size+1,size+1);
			for (int i = 0; i < map.Width; i++)
			{
				for (int j = 0; j < map.Height; j++)
				{
					byte height = heightMap[i + posX, j + posY];
					Color color; 
					if (     height < waterLevel) color = Color.FromArgb(255, 0, 119, 190);
					else if (height < waterLevel + 30) color = Color.FromArgb(255 - (int)(((height / 10 * 10 - waterLevel < 0) ? 0 :height / 10 * 10 - waterLevel) * 6), 234, 208, 150);
					else if (height < waterLevel + 60) color = Color.FromArgb(255, 51, 158, 24);
					else if (height < waterLevel + 90) color = Color.FromArgb(255, 51, 138, 24);
					else if (height < waterLevel + 120) color = Color.FromArgb(255, 50, 129, 0);
					else if (height < waterLevel + 150) color = Color.FromArgb(255, 50, 110, 0);
					else if (height < waterLevel + 180) color = Color.FromArgb(255, 110, 110, 0);
					else if (height < waterLevel + 210) color = Color.FromArgb(225, 110, 81, 0);
					else if (height < waterLevel + 240) color = Color.FromArgb(255, 102, 51, 0);
					else color = Color.FromArgb(255, 80, 35, 0);
					map.SetPixel(i, j, color);
				}
			}
			return map;
		}

		private static Bitmap MapStyle1(byte[,] heightMap, int waterLevel, int size,int posX = 0, int posY = 0)
		{
			NormalizeXY(size, ref posX, ref posY);
			Bitmap map = new Bitmap(size + 1, size + 1);
			for (int i = 0; i < map.Width; i++)
			{
				for (int j = 0; j < map.Height; j++)
				{
					byte height = heightMap[i + posX, j + posY];
					int shoreLevel = waterLevel + 30;

					if (height > shoreLevel)
						map.SetPixel(i, j, Color.FromArgb(122, 255 - height + waterLevel, 255 - height + waterLevel, 255 - height + waterLevel));
					else if (height >= waterLevel)
					{
						Color a = Color.FromArgb(122, 255 - height + waterLevel, 255 - height + waterLevel, 255 - height + waterLevel);
						Color b = Color.FromArgb(255 - (int)((height - waterLevel) * 8.5f), 234, 208, 150);
						int auxval = (int)((1 - (a.A / 255f)) * b.A + a.A);
						Color c = Color.FromArgb(
							auxval,
							(int)(((1 - (a.A / 255f)) * b.A * b.R + a.A * a.R) / auxval),
							(int)(((1 - (a.A / 255f)) * b.A * b.G + a.A * a.G) / auxval),
							(int)(((1 - (a.A / 255f)) * b.A * b.B + a.A * a.B) / auxval));

						map.SetPixel(i, j, c);

					}
					else
					{

						int aux = waterLevel - height;
						map.SetPixel(i, j, Color.FromArgb(255, 0, 119 - (int)(aux * 0.9f), 190));
					}
				}
			}
			return map;
		}
        private static Bitmap GetNewMap(string v)
        {
            string[] mapSettings = v.Split(secondarySeparator);
            MapSelection.acceptMapButton.Invoke((MethodInvoker)(() => MapSelection.acceptMapButton.Enabled = true));
            playerReady = false;
            enemyReady = false;
            size =       Convert.ToInt32(mapSettings[1]);
            minheight =  Convert.ToInt32(mapSettings[2]);
            maxheight =  Convert.ToInt32(mapSettings[3]);
            waterlevel = Convert.ToInt32(mapSettings[4]);
            offset =     Convert.ToInt32(mapSettings[5]);

            return GetNewMap(Convert.ToInt32(mapSettings[0]), Convert.ToInt32(mapSettings[1]),
                             Convert.ToInt32(mapSettings[2]), Convert.ToInt32(mapSettings[3]),
                             Convert.ToInt32(mapSettings[4]), Convert.ToInt32(mapSettings[5]));


        }
        private static void NormalizeXY(int size, ref int posX, ref int posY)
		{
			int border = size / 10;
			if (posX != 0)
			{
				if (posX - border <= 0)
				{
					posX = 0;
				}
				else if (posX + border > size)
				{
					posX = size;
				}
			}
			if (posY != 0)
			{
				if (posY - border <= 0)
				{
					posY = 0;
				}
				else if (posY + border > size)
				{
					posY = size;
				}
			}
		}
	}
}
