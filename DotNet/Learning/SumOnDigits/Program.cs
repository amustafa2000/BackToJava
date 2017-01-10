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
			int n = 00018881;
			Console.WriteLine(Sum(n));
            int sum = 0;
            int theLast = 0;
            while(n/10 != 0)
            {
                sum = sum + n % 10;
                n = n / 10;
                theLast = n;
            }
            sum = sum + theLast;
            Console.WriteLine("Sum of all the digits = " + sum);
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
