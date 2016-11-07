using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] strArray = new string[7] {"abcd","1Abcba1","abcddcba","xyz","xyzy","something","not" };
			for (int i = 0; i < strArray.Length; i++)
			{
				Console.WriteLine(strArray[i] + " " + IsPalindrome(strArray[i]));
			}
			Console.ReadKey();
		}
		static bool IsPalindrome(string theString)
		{
			theString = theString.ToLower();
			int middle = theString.Length / 2;
			for (int i = 0; i < middle; i++)
			{
				if (theString[i] != theString[theString.Length - i-1])
				{
					return false;
				}
			}
			return true;
		}
	}
}
