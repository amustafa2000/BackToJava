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
			// ** Generic is type safe. Collection is not.
			// ** Hashtable key value pairs
			Hashtable ht = new Hashtable();
			ht.Add("one", "1");
			ht.Add("xx", 1);
			bool one = ht.Contains("one");
			bool two = ht.Contains("two");
			foreach (object item in ht.Keys)
			{
				Console.WriteLine(item);
			}
			foreach (object item in ht.Values)
			{
				Console.WriteLine(item);
			}
			 foreach (DictionaryEntry di in ht)
			 {
               Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
			}
			//** IMP nullaboe andy operator is ?
			int? i = null;
			//** IMP nullaboe andy operator is ?
			object someobj = "";
	
			SomeClass xxxsss = someobj as SomeClass;


			// ** Create arrays with fixed dimensions
			int[] a = new int[] { 1, 2, 33 };
			SomeClass[] someClassesArray = new SomeClass[3];
			someClassesArray[0] = new SomeClass();
			someClassesArray[1] = new SomeClass();
			someClassesArray[2] = new SubSomeClass(); // SubSomeClass is same type of SomeClass
			Console.WriteLine("a = " + a[0]);

			foreach (SomeClass sc in someClassesArray)
			{
				Console.WriteLine(sc);
			}

			int xxx = 3;
			int[] ip = new int[xxx];
			ip[0] = 0;
			ip[1] = 1;
			ip[2] = 2;


			List<int> intList = new List<int>();
			intList.Add(1);
			intList.Add(2);

			List<object> objList = new List<object>();
			objList.Add(1);
			objList.Add("aaa");
			objList.Add(new SubSomeClass());
			objList.Add(new SomeClass());

			ArrayList al = new ArrayList();
			al.Add(1);
			al.Add("a");
			string name = "sandeep";
			string myName = name;
			Console.WriteLine("== operator result is {0}", name == myName);
			Console.WriteLine("Equals method result is {0}", name.Equals(myName));

			object name2 = "sandeep";
			Console.WriteLine("xx== operator result is {0}", name == name2);
			Console.WriteLine("xxEquals method result is {0}", name.Equals(name2));
			
			char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
			object myNamex = new string(values);
			Console.WriteLine("hhxx== operator result is {0}", name == myNamex);
			Console.WriteLine("hhxxEquals method result is {0}", name.Equals(myNamex));

			Dictionary<int, string> myDictionary = new Dictionary<int, string>();
			myDictionary.Add(1, "one");
			// ** Update a value ACCESS the Key as INDEX
			myDictionary[1] = "updatedOne";
			foreach (KeyValuePair<int, string> pair in myDictionary)
			{
				Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
			}
			Console.WriteLine("hhxx== operator result is {0}", myDictionary[1]);
			Console.ReadKey();
		}
	}
	class SomeClass
	{

	}
	class SubSomeClass:SomeClass
	{

	}
}
