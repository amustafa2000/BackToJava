using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorExample
{
	class LINQ_Lambda_EnumeratorExample
	{
		static void Main(string[] args)
		{
			List<String> strList = new List<String>();
			strList.Add("dd");
			strList.Add("aa");
			strList.Add("bb");
			strList.Add("cc");
			//strList.RemoveAll(x => x.IndexOf("aa") != -1);
			var person = new { firstName = "John", lastName = "Smith" };
			Console.WriteLine(person.lastName);
			object[] ip = new object[1];
			ip[0] = person;
			TestAnnonimousPassing(person, ip);

			IEnumerable<String> queryAA = strList.Where(x => x.IndexOf("aa") != -1);
			Console.WriteLine("Only AA ...");
			foreach (String s in queryAA)
			{
				Console.WriteLine("XXX = " + s);
			}

			IEnumerable<String> query = strList.OrderBy(x => x);
			Console.WriteLine("Ascending ...");
			foreach (String s in query)
			{
				Console.WriteLine("XXX = " + s) ;
			}
			query = strList.OrderByDescending(x => x);
			Console.WriteLine("");
			Console.WriteLine("Descending ...");
			foreach (String s in query)
			{
				Console.WriteLine("XXX = " + s);
			}


			IEnumerable<String> ie = strList;
			EnumeratorExample ee = new EnumeratorExample();
			IEnumerator<String> myEunmerator = ee.Enumerate(ie);
			while (myEunmerator.MoveNext())
			{
				object item = myEunmerator.Current;
				Console.WriteLine(item);
				// Perform logic on the item

			}

			Console.WriteLine("Reset");
			myEunmerator.Reset();
			while (myEunmerator.MoveNext())
			{
				object item = myEunmerator.Current;
				Console.WriteLine(item);
				// Perform logic on the item

			}
		}
		public static void TestAnnonimousPassing(dynamic dyn, params object[] paramObjs)
		{
			var obj = paramObjs[0];
			Console.WriteLine(obj);
		}
	}

	public class EnumeratorExample
	{
		//Pass in Enumerable get Enumerator
		public IEnumerator<String> Enumerate(IEnumerable<String> enumerable)
		{
			// List implements IEnumerable, but could be any collection.
			List<string> list = new List<string>();

			foreach (string value in enumerable)
			{
				list.Add(value + " Added XXXX");
			}
			return list.GetEnumerator();
		}
	}
}
