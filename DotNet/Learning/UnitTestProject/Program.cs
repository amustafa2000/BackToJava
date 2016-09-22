using System;
using NUnit.Framework;
using Moq;

namespace NUnitAndMOQProject
{
	class Program
	{
		static void Main(string[] args)
		{
			TestClass adTest = new TestClass();
			adTest.TestMethod();
		}
	}
	public class CheckEmployee
	{
		public virtual Boolean checkEmp()
		{
			throw new NotImplementedException();
		}
	}

	public class ProcessEmployee
	{
		public Boolean insertEmployee(CheckEmployee objtmp)
		{
			objtmp.checkEmp();
			return true;
		}
	}
	public class NumberAdder
	{
		public virtual int ExecuteAddTheNumbers(NumberBank adder)
		{
			return adder.numberOne + adder.numberTwo;
		}
	}
	public class NumberBank
	{
		public int numberOne = 0;
		public int numberTwo = 0;
		public NumberBank(int a, int b)
		{
			this.numberOne = a;
			this.numberTwo = b;
		}

		public virtual int AddTheNumbers(NumberAdder ua)
		{
			return ua.ExecuteAddTheNumbers(this);
		}

	}

	[TestFixture]
	public class TestClass
	{
		[Test]
		public void TestMethod()
		{
			/*
			 //These 3 lines gives error
			checkEmployee ce = new checkEmployee();
			processEmployee pe = new processEmployee();
			pe.insertEmployee(ce);
			 */

			Mock<CheckEmployee> chk = new Mock<CheckEmployee>();
			chk.Setup(x => x.checkEmp()).Returns(true);

			ProcessEmployee obje = new ProcessEmployee();
			Assert.AreEqual(obje.insertEmployee(chk.Object), true);
			try
			{
				NumberBank adder = new NumberBank(3,3);
				NumberAdder twoN = new NumberAdder();
				Assert.AreEqual(6, twoN.ExecuteAddTheNumbers(adder));



				NumberBank numberBack = new NumberBank(5, 5);
				Mock<NumberAdder> mockUA = new Mock<NumberAdder>();
				mockUA.Setup(x => x.ExecuteAddTheNumbers(numberBack)).Returns(6);
				
				int mockedInvocation = numberBack.AddTheNumbers(mockUA.Object);
				Assert.AreEqual(6, mockedInvocation);
				Console.WriteLine("passed");
			}
			catch (Exception e)
			{
				Console.WriteLine("failed");
			}
		}
			
	}

}
