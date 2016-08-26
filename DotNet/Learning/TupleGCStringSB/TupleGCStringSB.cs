using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class TupleGCStringSB
	{
		public static void Main(string[] args)
		{
			TestClass tgc = new TestClass();
			tgc.GarbaseCollect();
			tgc.CreateTupples();
			tgc.StrVSSTrBuilder();
			
			System.Console.WriteLine("...");
		}
	}
	public interface TestInterface
	{
		void Walk();
	}
	public interface TestInterfaceX
	{
		void Talk();
	}
	public interface TestInterface2 : TestInterface, TestInterfaceX
	{
		void Walk2();
	}
	public class Species
	{
		public Species()
		{

		}
		public Species(string type)
		{

		}
	}
	public class Human : Species, TestInterface2
	{
		public Human()
		{
		}
		public Human(string type)
		{
		}
		public void Walk()
		{
		}
		public void Walk2()
		{
		}
		public void Talk()
		{
			try
			{
				string s = null;
				s.Equals("");
				try
				{
					string ss = null;
					ss.Equals("");
				}
				catch (Exception e)
				{
					throw e;
				}
			}
			catch (Exception e)
			{
				throw e;
			}

		}
	}

	public class TestClass
	{
		public TestClass()
		{
			System.Console.WriteLine("IN Constructor");
		}

		public void CreateTupples()
		{
			Tuple<String, int> tNew = new Tuple<String, int>("Hellow", 2);
			Tuple<int, int, int> tCreate = Tuple.Create<int, int, int>(2, 4, 5);
		}

		public void GarbaseCollect()
		{
			for (int i = 0; i < 100; i++)
			{
				if (i == 50)
				{
					System.GC.Collect();
				}
			}
		}
		public void StrVSSTrBuilder()
		{
			Stopwatch stopWatch = new Stopwatch();
			stopWatch.Start();
			String firstTest = "";
			int loopFor = 50000;
			for (int i = 0; i < loopFor; i++)
			{
				firstTest = firstTest + i;
			}
			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds,
				ts.Milliseconds / 10);
			Console.WriteLine("RunTime " + elapsedTime);


			stopWatch.Reset();
			stopWatch.Start();
			StringBuilder bufferTest = new StringBuilder();
			for (int i = 0; i < loopFor; i++)
			{
				bufferTest.Append(i);
			}
			stopWatch.Stop();
			TimeSpan ts2 = stopWatch.Elapsed;
			string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts2.Hours, ts2.Minutes, ts2.Seconds,
				ts.Milliseconds / 10);
			Console.WriteLine("RunTime " + elapsedTime2);
			Console.ReadLine();

		}
	}
}
