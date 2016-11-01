using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int [] intArray = {1,2};
			int[] intArrayTwo = new int[2];
			intArrayTwo[0] = 11;
			intArrayTwo[1] = 22;

			int dimA = 4;
			int dimB = 4;
			int[][] twoDimArray = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 }, new int[] { 13, 14, 15, 16 } };
			for (int i = 0; i <= dimA-1; i++)
			{
				string toPrint = "";
				for (int j = 0; j <= dimB-1; j++)
				{
					toPrint += twoDimArray[i][j];
					if (j != dimB-1) toPrint += ",";
				}
				Console.WriteLine(toPrint);
			}

			Console.ReadKey();
		}
	}
}
