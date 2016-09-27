using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorVsIEnumarable
{
	class IEnumerator_IEnumarable
	{
		static void Main(string[] args)
		{
			// **IEnumerator Cursor has the state can pass to another function
			// *** IEnumerable DOES not retain state

			string xxx = "http://sp2013ii:8081/#/security ";
			Uri refDataUri = new Uri(xxx);
			string refDataHost = refDataUri.Host;
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
