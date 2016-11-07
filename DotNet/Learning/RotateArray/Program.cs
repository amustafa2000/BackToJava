using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RotateArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] theArray = new int[4] {1,2,3,4};
			int noOfElementsToRotate = 3;
			int tempValue;
			for (int i = 0; i < noOfElementsToRotate; i++)
			{
				tempValue = theArray[0];
				for (int j = 0; j < theArray.Length -1; j++)
				{
					int temp = theArray[j+1];
					theArray[j] = temp;
				}
				theArray[theArray.Length - 1] = tempValue;
			}
			Console.WriteLine(theArray);
			Console.ReadKey();

		}
	}
}
