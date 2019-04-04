using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame_v2
{
	static partial class Engine
	{
		public static Random rnd = new Random();
		public static byte GetHeight(float x,float y)
		{
			return hMap[(int)x, (int)y];
		}
	}
}
