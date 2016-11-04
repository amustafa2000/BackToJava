using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMajorityElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] theArray = { 1, 2, 3, 4, 5, 2, 2, 2, 2 };
			Console.WriteLine("Majority is = " + GetMajorityElement(theArray));
			Console.ReadKey();
		}
		public static int GetMajorityElement(int[] x)
		{
			Dictionary<int, int> d = new Dictionary<int, int>();
			int majority = x.Length / 2;
			int reminder = x.Length / 2;
			if (reminder != 0) majority++;
			foreach(int i in x)
			{
				if (d.ContainsKey(i))
				{
					d[i] = d[i] + 1;
					if (d[i] == majority)
					{
						return i;
					}
				}
				else
				{
					d[i] = 1;
				}
			}
			return -1;
		}

	}
}
