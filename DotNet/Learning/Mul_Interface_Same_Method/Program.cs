using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mul_Interface_Same_Method
{
	class Program
	{
		static void Main(string[] args)
		{
			A Obj1 = new Test();
			Obj1.Hello();

			B Obj2 = new Test();
			Obj2.Hello();
			Console.ReadKey();
		}
	}
	interface A
	{
		void Hello();
	}

	interface B
	{
		void Hello();
	}

	class Test : A, B
	{
		void A.Hello()
		{
			Console.WriteLine("Hello to all-A");
		}

		void B.Hello()
		{
			Console.WriteLine("Hello to all-B");
		}
	}
}
