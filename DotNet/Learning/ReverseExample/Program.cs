using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseExample
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputString = "one two three four five";
			string resultString = string.Join(" ", inputString.Split(' ').Select(x => new String(x.Reverse().ToArray())));

			string resultStringx = string.Join(" ", inputString.Split(' ').Select(x => new String(x.Reverse().ToArray())));
			Console.WriteLine(resultString);
		}
	}
}
