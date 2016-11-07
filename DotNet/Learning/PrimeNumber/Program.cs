using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 100; i++)
			{
				IsPrime(i);
			}
			Console.ReadKey();
		}
		static bool IsPrime(int theNumber)
		{
			if (theNumber == 2)
			{
				Console.WriteLine(theNumber + " is a PRIME number");
				return true;
			}
			for (int i = 2; i < theNumber / 2 +1; i++)
			{
				if (theNumber % i == 0)
				{
					//Console.WriteLine(theNumber + " is Not a prime number");
					return false;
				}
			}
			Console.WriteLine(theNumber + " is a PRIME number");
			return true;
		}
	}
}
