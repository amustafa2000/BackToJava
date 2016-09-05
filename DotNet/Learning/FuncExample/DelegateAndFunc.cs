using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndFunc
{
	class DelegateAndFunc
	{
		public delegate int AddOne(int somthing);
		static void Main(string[] args)
		{
			Func<int, int> funcAddOne = theInt => theInt + 1;
			Console.WriteLine("xxxxxxxxxxx " + funcAddOne(2));
			
			AddOne  addOne = AddOneActual;
			Console.WriteLine("Actual " + AddOneActual(2));
			Console.WriteLine("Actual " + addOne(2));

			AddOne addOne2 = AddOneWrong;
			Console.WriteLine("Wrong " + addOne2(2));
			Console.WriteLine("Wrong " + AddOneWrong(2));

			Func<int, int> anotherTest = delegate(int someIntx)
			{
				return someIntx + 4;
			};

			Console.WriteLine("delegate XX " + anotherTest(2));

			int oo = 0;
		}

		public static int AddOneActual(int something)
		{
			
			return something +1;
		}
		public static int AddOneWrong(int something)
		{
			return something + 2;
		}
	}
}
