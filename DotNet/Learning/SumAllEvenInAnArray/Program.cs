using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumAllEvenInAnArray
{
	class Program
	{
		public static DateTime notInitializedDateTime;
		public static int notInitializedInt;
		public static String notInitializedString;
		public static void Main(string[] args)
		{
			int[] theArray = {2,4,6};
			PrintAllPositiveItems(theArray);
			Console.WriteLine(SumAllEven(theArray));
			Console.ReadKey();
		}
		public static long SumAllEven(int[] theArray)
		{
			return theArray.Where(i => i % 2 == 0).Sum(i => (long)i);
		}
		public static void PrintAllPositiveItems(int[] theArray)
		{
			long total = 0;
			theArray.ToList().ForEach(ele => total = total + ele);
			Console.WriteLine(total);
		}
	}
}
