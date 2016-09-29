using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DI_IOC_II
{
	class Program
	{
		static void Main(string[] args)
		{
			UnityContainer uc = new UnityContainer();
			//ClassA ca = new ClassA();
			ClassB cb = new ClassB(id:2000);
			//uc.RegisterInstance(ca);
			uc.RegisterInstance(cb);
			uc.RegisterType<IClassA, ClassA>();
			ClassC cc = uc.Resolve<ClassC>();
		}
	}
	public interface IClassA
	{
		void ClassAInterfaceMethod();
	}
	public class ClassA: IClassA
	{
		public ClassA()
		{
		}
		public void ClassAInterfaceMethod()
		{
			Console.WriteLine("xxxxx");
		}
	}
	public class ClassB
	{
		private int id = 0;
		public ClassB(int id)
		{
			this.id = id;
		}
	}
	public class ClassC
	{
		private IClassA ca;
		private ClassB cb;
		public ClassC(IClassA a, ClassB b)
		{
			this.ca = a;
			this.cb = b;
		}
	}
}
