using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndFunc
{
	class DelegateAndFunc
	{
		// ** A delegate can be seen as a placeholder for a/some method(s).
		public delegate int AddOne(int somthing);
		public delegate int AddTwoNumbers(int somthing, int something2);

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

			Func<string, int, int> anotherTest = delegate(string x, int someIntx)
			{
				int xxxxxxx = AddOneActual(3);
				return someIntx + 4;
			};
			Console.WriteLine("delegate XX " + anotherTest("", 2));
			
			AddTwoNumbers addTwoNUmbers = AddTwoNumbersImpl;
			Console.WriteLine("delegate AddTwoNumbersImpl " + addTwoNUmbers(3, 2));

			Console.ReadKey();
		}

		public static int AddOneActual(int something)
		{
			
			return something +1;
		}
		public static int AddOneWrong(int something)
		{
			return something + 2;
		}
		public static int AddTwoNumbersImpl(int something, int something2)
		{
			return something + something2;
		}
	}
}
