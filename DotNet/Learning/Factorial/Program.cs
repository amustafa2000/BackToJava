using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i < 7; i++)
			{
				Console.WriteLine("Factorial of " + i + " = " + Factorial(i));
			}
			Console.ReadKey();
		}
		static int Factorial(int num)
		{
			if (num == 1)
			{
				return 1;
			}
			else
			{
				return num * Factorial(num-1);
			}
		}
	}
}
