using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayVsArrayListVsList
{
	class ArrayVsArrayListVsList
	{
		static void Main(string[] args)
		{
			int[] a = new int[] { 1, 2, 33 };
			Console.WriteLine("a = " + a[0]);
			int xxx = 3;
			int[] ip = new int[xxx];
			ip[0] = 0;
			ip[1] = 1;
			ip[2] = 2;


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
