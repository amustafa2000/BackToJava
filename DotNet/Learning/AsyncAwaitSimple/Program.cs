using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitSimple
{
	class Program
	{
		static void Main(string[] args)
		{
			Method();
			Console.WriteLine("*** immediately here Main Method Actually waits");
			Console.ReadKey();
		}
		public static async void Method()
		{
			await Task.Run(new Action(LongTask));
			Console.WriteLine("Waited");
		}
		public static void LongTask()
		{
			Thread.Sleep(5000);
		}
	}
	
}
