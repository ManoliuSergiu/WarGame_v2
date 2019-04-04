using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame_v2
{
	static partial class Engine
	{
		static byte[,] hMap;

		public static Bitmap GetNewMap(bool colorScheme=false,int size = 512, int min = 5, int max = 255, int waterLevel = 60, int offset = 120)
		{
			hMap = DiamondSquareGen.Generate(size, min, max,offset);
			return DrawMap(colorScheme,waterLevel, size);
		}

		public static Bitmap DrawMap(bool colorScheme = false, int waterLevel=60, int size = 512, int posX = 0, int posY = 0)
		{
			if (colorScheme)
			{
				return MapStyle2(waterLevel, size);
			}
			else
			{
				return MapStyle1(waterLevel, size);
			}
		}

		private static Bitmap MapStyle2(int waterLevel, int size)
		{
			Bitmap map = new Bitmap(size+1,size+1);
			for (int i = 0; i < map.Width; i++)
			{
				for (int j = 0; j < map.Height; j++)
				{
					Color color; 
					if (hMap[i, j] < waterLevel) color = Color.FromArgb(255, 0, 119, 190);
					else if (hMap[i, j] < waterLevel + 20) color = Color.FromArgb(255 - (int)(((hMap[i, j] / 10 * 10 - waterLevel < 0) ? 0 : hMap[i, j] / 10 * 10 - waterLevel) * 6), 234, 208, 150);
					else if (hMap[i, j] < waterLevel + 60) color = Color.FromArgb(255, 51, 158, 24);
					else if (hMap[i, j] < waterLevel + 90) color = Color.FromArgb(255, 51, 138, 24);
					else if (hMap[i, j] < waterLevel + 120) color = Color.FromArgb(255, 50, 129, 0);
					else if (hMap[i, j] < waterLevel + 150) color = Color.FromArgb(255, 50, 110, 0);
					else if (hMap[i, j] < waterLevel + 180) color = Color.FromArgb(255, 110, 110, 0);
					else if (hMap[i, j] < waterLevel + 210) color = Color.FromArgb(225, 110, 81, 0);
					else if (hMap[i, j] < waterLevel + 240) color = Color.FromArgb(255, 102, 51, 0);
					else color = Color.FromArgb(255, 80, 35, 0);
					map.SetPixel(i, j, color);
				}
			}
			return map;
		}

		private static Bitmap MapStyle1(int waterLevel, int size)
		{
			Bitmap map = new Bitmap(size + 1, size + 1);
			
			for (int i = 0; i <  size + 1; i++)
			{
				for (int j = 0; j < size + 1; j++)
				{

					int shoreLevel = waterLevel + 30;
					if (hMap[i, j] > shoreLevel)
						map.SetPixel(i, j, Color.FromArgb(122, 255 - hMap[i, j] + waterLevel, 255 - hMap[i, j] + waterLevel, 255 - hMap[i, j] + waterLevel));

					else if (hMap[i, j] >= waterLevel)
					{
						Color a = Color.FromArgb(122, 255 - hMap[i, j] + waterLevel, 255 - hMap[i, j] + waterLevel, 255 - hMap[i, j] + waterLevel);
						Color b = Color.FromArgb(255 - (int)((hMap[i, j] - waterLevel) * 8.5f), 234, 208, 150);
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

						int aux = waterLevel - hMap[i, j];
						map.SetPixel(i, j, Color.FromArgb(255, 0, 119 - (int)(aux * 0.9f), 190));
					}
				}
			}
			return map;
		}
	}
}
