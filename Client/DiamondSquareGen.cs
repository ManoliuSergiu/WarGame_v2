using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
	class DiamondSquareGen
	{
        static Random rnd;
        public static byte[,] Generate(int seed = 11111, int size = 2048, int min = 1, int max = 255, float offset = 150)
        {
            rnd = new Random(seed);
            byte[,] heightmap = new byte[size + 1, size + 1];
            heightmap[0, 0] = (byte)rnd.Next(min, max);
            heightmap[size, 0] = (byte)rnd.Next(min, max); ;
            heightmap[0, size] = (byte)rnd.Next(min, max);
            heightmap[size, size] = (byte)rnd.Next(min, max);
            int iterations = (int)Math.Log(size, 2);
            for (int i = 0; i < iterations; i++)
            {
                int sqSize = (int)(size / Math.Pow(2, i));
                for (int j = 0; j < size; j += sqSize)
                {
                    for (int k = 0; k < size; k += sqSize)
                    {
                        DiamondStep(sqSize, j, k, heightmap, (int)offset, min, max);
                        SquareStep(sqSize, j, k, heightmap, (int)offset, size, min, max);

                    }
                }
                offset *= 0.5f;
            }
            Smoothing(heightmap, 1, size, 3);
            return heightmap;

        }

		private static void Smoothing(byte[,] heightmap, int v,int size,int iterations)
		{
			for (int times = 0; times < iterations; times++)
			{

				for (int i = 0; i <= size; i++)
				{
					for (int j = 0; j <= size; j++)
					{
						int aux = 0;
						int sum = 0;
						for (int k = -v; k <= v; k++)
						{
							for (int l = -v; l <= v; l++)
							{
								if (k + i >= 0 && k + i < size && j + l >= 0 && j + l < size)
								{
									sum += heightmap[i + k, j + l];
									aux++;
								}
							}
						}
						heightmap[i, j] = Convert.ToByte(sum / aux);
					}
				}
			}

		}

		private static void SquareStep(int squareSize, int squarePositionX, int squarePositionY, byte[,] heightmap, int offset,int totalSize,int scatteredness,int maxsize)
		{
			int halfSize = (int)(squareSize * 0.5);
			int centerX = squarePositionX + halfSize;
			int centerY = squarePositionY + halfSize;

			int currentX = centerX;
			int currentY = centerY - halfSize;

			SubSquareStep(heightmap, offset, totalSize, halfSize, currentX, currentY, scatteredness, maxsize);
			currentX = centerX;
			currentY = centerY + halfSize;
			SubSquareStep(heightmap, offset, totalSize, halfSize, currentX, currentY, scatteredness, maxsize);
			currentX = centerX - halfSize;
			currentY = centerY;
			SubSquareStep(heightmap, offset, totalSize, halfSize, currentX, currentY, scatteredness, maxsize);
			currentX = centerX + halfSize;
			currentY = centerY;
			SubSquareStep(heightmap, offset, totalSize, halfSize, currentX, currentY, scatteredness, maxsize);

		}

		private static void SubSquareStep(byte[,] heightmap, int offset, int totalSize, int halfSize, int currentX, int currentY, int scatteredness, int maxsize)
		{
            int k = 0;
			int a=0, b=0, c=0, d=0;
			if (currentY - halfSize >= 0)
			{
				a = heightmap[currentX, currentY - halfSize];
				k++;
			}
			if (currentX - halfSize >= 0)
			{
				b = heightmap[currentX - halfSize, currentY];
				k++;
			}
			if (currentY + halfSize <= totalSize)
			{
				c = heightmap[currentX, currentY + halfSize];
				k++;
			}
			if (currentX + halfSize <= totalSize)
			{
				d = heightmap[currentX + halfSize, currentY];
				k++;
			}
            int aux = a + b + c + d;
            if (aux<k)
			{
				aux = k;
			}
			aux /= k;
            int aux1;
            do
			{
				aux1 = aux + rnd.Next(-offset - scatteredness/2, offset + scatteredness + 1);
			} while (aux1 < 1 || aux1 > maxsize);
			heightmap[currentX, currentY] = (byte)aux1;
		}

		private static void DiamondStep(int squareSize,int squarePositionX, int squarePositionY, byte[,] heightmap, int offset, int scatteredness, int maxsize)
		{
			int halfSize = (int)(squareSize * 0.5);
			int centerX = squarePositionX + halfSize; 
			int centerY = squarePositionY + halfSize;
			int a = heightmap[centerX - halfSize, centerY - halfSize];
			int b = heightmap[centerX + halfSize, centerY - halfSize];
			int c = heightmap[centerX - halfSize, centerY + halfSize];
			int d = heightmap[centerX + halfSize, centerY + halfSize];
			int aux = (int)((a+ b + c + d) * 0.25f);

            int aux1;
			do
			{
				aux1 = aux + rnd.Next(-offset - scatteredness/2, offset+scatteredness+1);
			} while (aux1<1||aux1>maxsize);
			heightmap[centerX, centerY] = (byte)aux1;
		}
	}
}
