using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
	class Struct
	{
		static void Main(string[] args)
		{
			StructExample se = new StructExample();
			se.x = 1;
			se.y = 2;
			int j = se.SumIt();

			for (int i = 0; i < 10000000; i++)
			{
				se.x = i;
				se.y = i+1;
				j= se.SumIt();
			}

			ABC myabc = new ABC();
			int k = 0;
		}
	}

	public class  ABC
	{
		public int x = 7;
		readonly int read = 10;
		const int cons = 10; 
		
		public ABC()
		{
			read = 12;
		}
	}
	public class BabyABC:ABC
	{
	}
	struct StructExample
	{
		public int x;
		public int y;

		public int SumIt()
		{
			return x + y;
		}
	}
	public interface INTF
	{
		int somemethod();
	}
}
