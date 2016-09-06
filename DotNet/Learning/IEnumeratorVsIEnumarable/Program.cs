using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorVsIEnumarable
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> intList = new List<int>();
			intList.Add(10);
			intList.Add(20);
			intList.Add(30);
			IEnumerable<int> iEnum = (IEnumerable<int>)intList;
			foreach (int item in iEnum)
			{
				Console.WriteLine(item);
			}
			IEnumerator<int> iEnumarator = intList.GetEnumerator();// Knows current CU

			while (iEnumarator.MoveNext())
			{
				Console.WriteLine(iEnumarator.Current.ToString());
			}
			int j = 1;
		}
	}
}
