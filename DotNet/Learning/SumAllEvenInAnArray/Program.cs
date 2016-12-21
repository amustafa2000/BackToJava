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
			string[] countries = {"aa", "bb", "cc" };
			string contated = countries.Aggregate((a,b) => a + ',' +b);

			int[] theArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// Lets try double where
			var result = theArray
				.Where(num => num % 2 == 0 && num % 3 == 0);

			foreach (int item in result)
			{
				Console.WriteLine("Sql Type loop = " + item);
			}
			// find the product of all the numbers
			long theProd = theArray.Aggregate((i, j) =>i*j);

			// Find the min even number
			// lambda
			int min = theArray.Where(i => InEven(i)).Min();
			int min2 = theArray.Min(item => item);

			// Find the sum of the even numbers in the array
			long theSum = theArray.Where(i => i % 2 == 0).Sum(i => (long)i);
			// **** As extension method can be invoked on the IEnumerable
			long sumUsingExtention = Enumerable.Where(theArray, i => i % 2 == 0).Sum(i => (long)i);
			
			IEnumerable<int> x = from num in theArray
							  where (num % 2) == 0
							  select num;
			foreach (int item in x)
			{
				Console.WriteLine("Sql Type loop = " + item);
			}
			IEnumerator<int> enumx = x.GetEnumerator();
			while (enumx.MoveNext())
			{
				Console.WriteLine("Sql Type loop = " + enumx.Current);
			}
			
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
		private static bool InEven(int num)
		{
			return num % 2 ==0;
		}
	}
}
