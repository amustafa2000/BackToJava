using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructVsClass
{
	/*
	 * All Objects are references
	 * 
	 * */
	class Program
	{
		enum e { AA, bb, cc };	
		static void Main(string[] args)
		{
			TestClass t1 = new TestClass();
			t1.Name = "xxx";
			TestClass t2 = t1;
			TestClass theClone = t1.cloneMe();
			t2.Name = "yyy";
			String s = "2";
			int sInt = Int32.Parse(s);
			Console.WriteLine(sInt++);
			Console.WriteLine(sInt);
			Console.WriteLine(++sInt);
			Console.WriteLine(sInt);
			Console.WriteLine(e.AA);
			if (0 == e.AA)
			{
				Console.WriteLine("Holly Molly");
			}
			switch(s)
			{
				case "x":
					break;
				default:
					break;

			}
			Console.ReadKey(); 
		}
	}
	class TestClass
	{
		private String _name;
		public TestClass()
		{
		}
		public string Name
		{
			set { _name = value; }
			get { return _name; }
		}
		public TestClass cloneMe()
		{
			TestClass tc = new TestClass();
			tc.Name = this.Name;
			return tc;
		}
	}
}
