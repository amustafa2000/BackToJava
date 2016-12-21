using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethod
{
	/* 1. Static Class
	 * 2. First Parameter is the the Class that the method will work on
	 * 3. this keyword should be used for the first parameter
	 **/
	class Program
	{
		static void Main(string[] args)
		{
			string s = "Some String";
			string otherString = s.ExtensionMethod();
			string sayHello = ExtensionClass.ExtensionMethod(s);
			List<int> xxx = new List<int>();
			xxx.ExtensionMethodx();
			Console.ReadKey();
		}
	}
	public static class ExtensionClass
	{
		/*
		 * IMP there should be a "this" in the 
		 * The first parameter is "string" the method is on
		 * */
		public static String ExtensionMethod(this string someString)
		{
			return "Hello";
		}
		public static String ExtensionMethodx(this List<int> someString)
		{
			return "Hello";
		}

	}
}
