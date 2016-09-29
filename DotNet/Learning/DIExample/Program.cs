using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DIExample
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Decouple */
			//IAddCustomer iOracle = new Oracle();
			//IAddCustomer iNoSQL = new NOSQL();
			//iOracle.AddCustomer();
			//iNoSQL.AddCustomer();

			/* Below is Using Unity Decoupled Architecture, DEPENDENCY Injection*/
			UnityContainer unityContainer = new UnityContainer();
			//Conditional Resolve perhaps from web config
			unityContainer.RegisterType<Customer>();
			unityContainer.RegisterType<IAddCustomer,NOSQL>();
			unityContainer.RegisterType<IAddCustomer, Oracle>();

			Customer obj = unityContainer.Resolve<Customer>();
			obj.AddCustomer();
			Console.WriteLine("xxx");
		}
	}
	public interface IAddCustomer
	{
		void AddCustomer();
	}

	public class Customer
	{
		private IAddCustomer theInterface;
		public Customer(IAddCustomer iAddCustomer)
		{
			this.theInterface = iAddCustomer;
		}
		public void AddCustomer()
		{
			theInterface.AddCustomer();
		}

	}

	public class Oracle : IAddCustomer
	{
		private int id = 0;
		public Oracle()
		{
		}
		public void AddCustomer()
		{
			Console.WriteLine("Oracle");
		}
		public void AddCustomerII()
		{
			Console.WriteLine("NOT from interface Oracle");
		}
	}
	public class NOSQL : IAddCustomer
	{
		public NOSQL()
		{
		}
		public void AddCustomer()
		{
			Console.WriteLine("NOSQL");
		}
	}
}
