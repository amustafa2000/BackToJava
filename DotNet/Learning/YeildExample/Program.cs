using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YeildExample
{
	class Program
	{
		static List<int> MyList = new List<int>();
		static void FillValues()
		{
			MyList.Add(1);
			MyList.Add(2);
			MyList.Add(3);
			MyList.Add(4);
			MyList.Add(5);
		}
		static void Main(string[] args)
		{
			FillValues();
			foreach (int i in Filter())
			{
				Console.WriteLine(i);
			}
			Console.ReadKey();
		}
		static IEnumerable<int> Filter()
		{
			int total = 0;
			foreach (int i in MyList)
			{
				if (i > 3)
				{
					total = total + i;
					yield return i;
				}
			}
			Console.WriteLine("Total = " + total);
		}
	}
}
