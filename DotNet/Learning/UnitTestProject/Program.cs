using System;
using NUnit.Framework;
using Moq;

namespace UnitTestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			TestClass adTest = new TestClass();
			adTest.TestMethod();
			// Just a test
			//Some Commit
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
		Mock<Adder> repositoryMock = new Mock<Adder>();
		[Test]
		public void TestMethod()
		{
			Adder adder = new Adder();

			try
			{
				repositoryMock.Setup(a => a.AddTheNumbers(3,21));
				Assert.AreEqual(2, repositoryMock.Setup(x => x.AddTheNumbers(1, 21)).Returns(3));
				//Assert.AreEqual(2, adder.AddTheNumbers(1, 21));
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
