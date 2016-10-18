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
			Task<int> longTask = n.MyMethodAsync();
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

		public async Task<int> MyMethodAsync()
		{
			Console.WriteLine("Just before calling long method");
			Task<int> longTask = LongRunningOperationAsync();
			Console.WriteLine("AFTER AWAIT 1");
			int longWaiting = await longTask;
			Console.WriteLine("AFTER AWAIT 2 " + longWaiting);

			//Same code as above
			Console.WriteLine("AFTER AWAIT 1");
			int longWaiting2 = await LongRunningOperationAsync();
			Console.WriteLine("AFTER AWAIT 2 " + longWaiting2);

			return 0;
		}
		public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
		{
			Console.WriteLine("Before waiting 10 seconds");
			await Task.Delay(10000); //1 seconds delay
			Console.WriteLine("10 seconds done Returning from Long Running method");
			return 11;
		}
	}
}
