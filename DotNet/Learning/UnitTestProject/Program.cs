﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			TestClass adTest = new TestClass();
			adTest.TestMethod();

		}
	}

	public class Adder
	{
		public Adder()
		{
		}

		public int AddTheNumbers(int i, int j)
		{
			return i+j;
		}
	}

	[TestFixture]
	public class TestClass
	{
		[Test]
		public void TestMethod()
		{
			Adder adder = new Adder();

			try
			{
				Assert.AreEqual(2, adder.AddTheNumbers(1, 21));
				Console.WriteLine("passed");
			}
			catch (Exception e)
			{
				Console.WriteLine("failed");
			}

			int j = 0;
		}
			
	}

}
