using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
	/*
	 * Selection sort is an algorithm of sorting an array where it loop from the start of the loop, and check through other elements to find the minimum value. 
	 * After the end of the first iteration, the minimum value is swapped with the current element. 
	 * The iteration then continues from the 2nd element and so on.
	 * */
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrayToSort = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            int[] sortedArray = arrayToSort.OrderBy(item => item).ToArray();
			Console.WriteLine("Before Sorting ...");
			for (int i = 0; i < arrayToSort.Length; i++)
			{
				Console.Write(arrayToSort[i] + ", ");
			}
			for (int i = 0; i < arrayToSort.Length; i++ )
			{
				int tempMinValue = arrayToSort[i];
				int tempMinIndex = i;
				for (int j = i + 1; j < arrayToSort.Length; j++)
				{
					if (arrayToSort[j] < tempMinValue)
					{
						tempMinValue = arrayToSort[j];
						tempMinIndex = j;
					}
				}
				if (tempMinIndex != i)
				{
					arrayToSort[tempMinIndex] = arrayToSort[i];
					arrayToSort[i] = tempMinValue;
				}
			}
			Console.WriteLine("");
			Console.WriteLine("After Sorting ...");
			for (int i = 0; i < arrayToSort.Length; i++)
			{
				Console.Write(arrayToSort[i] + ", ");
			}

			Console.ReadKey();
		}
	}
}
