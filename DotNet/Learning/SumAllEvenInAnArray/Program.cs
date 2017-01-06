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

            long sumTest = theArray.Sum(item => item);
            long sumEvenTest = theArray.Where(item => item % 2 == 0).Sum(item => item);
            long minEven = theArray.Where(item => item % 2 == 0).Min(item => item);
            int[] allEven = theArray.Where(item => item % 2 == 0).ToArray();
            long sumByAggregate = theArray.Aggregate((i, j) => i + j);

            // Lets try double where
            var result = theArray
				.Where(num => num % 2 == 0 && num % 3 == 0);

			foreach (int item in result)
			{
				Console.WriteLine("Sql Type loop = " + item);
			}
			// find the product of all the numbers
			long theProd = theArray.Aggregate((i, j) =>i*j);

            long theSumx = theArray.Aggregate((i, j) => i + j);
            long xxx = theArray.Sum(item => item);

            // Find the min even number
            // lambda
            int min = theArray.Where(i => InEven(i)).Min();
			int min2 = theArray.Min(item => item);

			// Find the sum of the even numbers in the array
			long theSum = theArray.Where(i => i % 2 == 0).Sum(i => (long)i);
			// **** As extension method can be invoked on the Enumerable
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
            total = 0;
            foreach (int myInt in theArray.ToList())
            {
                total = total + myInt;
            }
            Console.WriteLine(total);
        }
		private static bool InEven(int num)
		{
			return num % 2 ==0;
		}
	}
}
