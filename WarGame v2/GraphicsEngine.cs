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
		static byte[,] zoomedMap;

		public static  Bitmap GetNewMap(bool colorScheme=false,int size = 512, int min = 5, int max = 255, int waterLevel = 60, int offset = 120)
		{
			
			hMap =  DiamondSquareGen.Generate(size, min, max,offset);
			zoomedMap = GenerateZoomedMap(size);
			Bitmap result = DrawMap(colorScheme, waterLevel, size);
			return result;
		}

		private static byte[,] GenerateZoomedMap(int size)
		{
			byte[,] output = new byte[size * 2 + 1, size * 2 + 1];	 
			for (int i = 0; i < output.GetLength(0)-1; i+=2)
			{
				for (int j = 0; j < output.GetLength(1)-1; j+=2)
				{
					output[i, j] = hMap[i / 2, j / 2];
					output[i + 1, j] = (byte)((hMap[i / 2, j / 2] + hMap[i / 2 + 1, j / 2]+1) / 2);
					output[i, j + 1] = (byte)((hMap[i / 2, j / 2 + 1] + hMap[i / 2, j / 2 + 1]+1) / 2);
					output[i+1, j + 1] = (byte)((hMap[i / 2+1, j / 2 + 1] + hMap[i / 2, j / 2]+ hMap[i / 2+1, j / 2] + hMap[i / 2, j / 2+1] +3) / 4);
				}
			}
			return output;
		}

		public static Bitmap DrawMap(bool colorScheme = false, int waterLevel=60, int size = 512)
		{
			
			if (colorScheme)
				return MapStyle2(hMap, waterLevel, size);
			else
				return MapStyle1(hMap, waterLevel, size);
		}

		public static Bitmap ZoomMap(int posX,int posY,bool colorScheme = false, int waterLevel = 60, int size = 512)
		{
			if (colorScheme)
				return MapStyle2(zoomedMap, waterLevel, size,posX,posY);
			else
				return MapStyle1(zoomedMap, waterLevel, size,posX,posY);
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
