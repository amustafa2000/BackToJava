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

            int[,] twoDimArrayExample = new int[2, 3] { {1,2,3 }, {4,5,6} };

            //int[,] twoDimArrayExample = new int[3, 2] { { Two Elements }, { Two Elements }, {Two Elements} };

            int[,] twoDimArrayExample2 = new int[2, 6] { { 1, 2, 3,4,5,6}, { 7,8,9,10,11,12 }};

            //int[,,] twoDimArrayExample3 = new int[2, 3, 4] { { { FOUR Elements }, { FOUR Elements }, { FOUR Elements } }, { { FOUR Elements }, { FOUR Elements }, { FOUR Elements } } };
            int[,,] twoDimArrayExample3 = new int[2, 3, 4] { { {1,2,3,4 },{5,6,7,8 },{9,10,11,12 } }, { {13,14,15,16 },{17,18,19,20 },{21,22,23,24 } } };

            int sum = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        sum = sum + twoDimArrayExample3[i, j, k];
                    }
                }
            }
            int sum2 = 0;
            for (int i = 0; i < 25; i++)
            {
                sum2 = sum2 + i;
            }

            Console.WriteLine("sum = " + sum);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine(twoDimArrayExample3[0, 0, 0]);

            Console.WriteLine(twoDimArrayExample3[0,0,0]);

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
