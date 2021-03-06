﻿using System;
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
        /*
         *  If you don’t specify either new or overrides, the resulting output is the same
         *  as if you specified new, but you’ll also get a compiler warning (as you may not be aware that you’re
         *  hiding a method in the base class method, or indeed you may have wanted to override it, and merely forgot to
         *  include the keyword).
         * */
        public new void VirtualClassMethod()
		{
			//base.VirtualClassMethod();
			Console.WriteLine("In SubClass with No Override method");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{

			List<string> FirstList = new List<string> { "1", "2", "testing, really testing" };
			//string joined = "'" + string.Join("','", FirstList) + "'";
			List<string> SecondList = new List<string> { "2", "1", "xxx", "testing, really testing" };
			List<string> ThirdList = SecondList.Except(FirstList).ToList();

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
