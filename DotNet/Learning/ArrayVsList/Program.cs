using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayVsList
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] a = new int[] { 1, 2, 33 };
			Console.WriteLine("a = " + a[0]);
			
			List<int> intList = new List<int>();
			intList.Add(1);
			intList.Add(2);


			ArrayList al = new ArrayList();
			al.Add(1);
			al.Add("a");

			Console.ReadKey();
		}
	}
}
