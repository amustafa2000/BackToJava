using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTest
{
	class Program
	{
		static void Main(string[] args)
		{
			TestAsync n = new TestAsync();
			Task<string> longTask = n.MyMethodAsync();
			Console.WriteLine("Main Method");
			Console.WriteLine("XX" + longTask);
			Console.ReadKey();
		}
	}

	public class TestAsync
	{
		public TestAsync()
		{

		}

		public async Task<string> MyMethodAsync()
		{
			Console.WriteLine("Just before calling long method");
			Task<string> longTask = LongRunningOperationAsync();
			Console.WriteLine("AFTER AWAIT 1");
            string longWaiting = await longTask;
			Console.WriteLine("AFTER AWAIT 2 " + longWaiting);

			//Same code as above
			Console.WriteLine("AFTER AWAIT 1");
			string longWaiting2 = await LongRunningOperationAsync();
			Console.WriteLine("AFTER AWAIT 2 " + longWaiting2);

			return "0";
		}
		public async Task<string> LongRunningOperationAsync() // assume we return an int from this long running operation 
		{
			Console.WriteLine("Before waiting 10 seconds");
			await Task.Delay(5000); //1 seconds delay
			Console.WriteLine("10 seconds done Returning from Long Running method");
			return "11";
		}
	}
}
