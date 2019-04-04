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

		public static Bitmap GetNewMap(int size = 512, int min = 5, int max = 255, int waterLevel = 60, int offset = 120)
		{
			hMap = DiamondSquareGen.Generate(size, min, max,offset);
			return DrawMap(waterLevel, size);
		}

		public static Bitmap DrawMap(int waterLevel, int size = 512, int posX = 0, int posY = 0)
		{
			Bitmap map = new Bitmap(size + 1, size + 1);
			if (posX != 0)
			{
				if (posX - size / 2 < 0)
					posX = 0;
				else if (posX + size > hMap.GetLength(0))
					posX = hMap.GetLength(0) - size-1;
				else posX = posX - size / 2;
			}
			if (posY !=0)
			{
				if (posY - size / 2 < 0)
					posY = 0;
				else if (posY + size > hMap.GetLength(1))
					posY = hMap.GetLength(1) - size -1;
				else posY = posY - size / 2;
			}
			for (int i = posX; i < posX + size + 1; i++)
			{
				for (int j = posY; j < posY + size + 1; j++)
				{

					int aux2 = waterLevel + 30;
					if (hMap[i, j] > aux2)
						map.SetPixel(i-posX, j-posY, Color.FromArgb(122, 255 - hMap[i, j] + waterLevel, 255 - hMap[i, j] + waterLevel, 255 - hMap[i, j] + waterLevel));
					else if (hMap[i, j] >= waterLevel)
					{
						Color a = Color.FromArgb(122, 255 - hMap[i, j] + waterLevel, 255 - hMap[i, j] + waterLevel, 255 -hMap[i, j ] + waterLevel);
						Color b = Color.FromArgb(255 - (int)((hMap[i, j] - waterLevel) * 8.5f), 234, 208, 150);
						int auxval = (int)((1 - (a.A / 255f)) * b.A + a.A);
						Color c = Color.FromArgb(
							auxval,
							(int)(((1 - (a.A / 255f)) * b.A * b.R + a.A * a.R) / auxval),
							(int)(((1 - (a.A / 255f)) * b.A * b.G + a.A * a.G) / auxval),
							(int)(((1 - (a.A / 255f)) * b.A * b.B + a.A * a.B) / auxval));

						map.SetPixel(i - posX, j - posY, c);

					}
					else
					{

						int aux = waterLevel - hMap[i, j];
						map.SetPixel(i - posX, j - posY, Color.FromArgb(255,0, 119 - (int)(aux * 0.9f), 190));
					}
				}
			}
			return map;
		}
	}
}
