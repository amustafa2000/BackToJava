using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOnDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			int theNumber = 00012301;
			Console.WriteLine(Sum(theNumber));
			Console.ReadKey();
		}
		static int Sum(int theNumber)
		{
			if (theNumber < 10)
			{
				return theNumber;
			}
			else
			{
				return Sum(theNumber % 10 + theNumber/10);
			}
		}
	}
}
