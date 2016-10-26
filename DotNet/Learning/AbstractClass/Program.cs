using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
	public class AbstractClass 
	{
		public virtual void VirtualClassMethod()
		{
			Console.WriteLine("Inside Abstract base Calss Impl");
		}
	}

	public class SomeClassUsesAbstractImpl : AbstractClass
	{

	}
	public class SomeClassOverrides : AbstractClass
	{
		public override void VirtualClassMethod()
		{
			//base.VirtualClassMethod();
			Console.WriteLine("In SubClass");
		}
	}
	public class NoOverrideKeyWordImpl : AbstractClass
	{
		public void VirtualClassMethod()
		{
			//base.VirtualClassMethod();
			Console.WriteLine("In SubClass with No Override method");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			AbstractClass cl1 = new SomeClassUsesAbstractImpl();
			cl1.VirtualClassMethod();
			AbstractClass cl2 = new SomeClassOverrides();
			cl2.VirtualClassMethod();
			SomeClassOverrides cl3 = new SomeClassOverrides();
			cl3.VirtualClassMethod();

			//Important how new is used NoOverrideKeyWordImpl vs AbstractClass
			Console.WriteLine("NoOverrideKeyWordImpl willUseOWn = new NoOverrideKeyWordImpl() -->");
			NoOverrideKeyWordImpl willUseOWn = new NoOverrideKeyWordImpl();
			willUseOWn.VirtualClassMethod();
			Console.WriteLine("AbstractClass willUseBase = new NoOverrideKeyWordImpl() -->");
			AbstractClass willUseBase = new NoOverrideKeyWordImpl();
			willUseBase.VirtualClassMethod();
			Console.ReadKey();
		}
	}
}
