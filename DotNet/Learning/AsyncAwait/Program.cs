using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
	class Program {
		private static string result = "Initial";
 
		static void Main() {
			SaySomething();
			Console.WriteLine("Printing result = "+result);
			for (int i = 0; i < 1000000; i++)
			{
				string s = i.ToString();
			}
			Console.ReadKey();
		}
 
		static async Task<string> SaySomething() {
			Console.WriteLine("Before 5 ms delay");
			await Task.Delay(5);
			result = "Hello world!";
			Console.WriteLine("After await");
			return "Something";
		}
	}
}
