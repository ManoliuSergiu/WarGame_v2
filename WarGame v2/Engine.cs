using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame_v2
{
	static partial class Engine
	{
		public static Random rnd = new Random();
		public static byte GetHeight(int x,int y)
		{

			if (Form1.form1.zoomed)
			{
				Point aux = Form1.form1.zoomPoint;
				return zoomedMap[aux.X + x, aux.Y+y ];
			}
			else
				return hMap[(int)x, (int)y];
		}
	}
}
