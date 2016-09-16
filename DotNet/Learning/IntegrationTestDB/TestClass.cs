using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTestDB
{
	[TestFixture]
	public class TestClass
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test code here
			Assert.Pass("Your first passing test");
		}
	}
	public class SomeService
	{
		IRepository repo;
		public SomeService(IRepository repo)
		{
			this.repo = repo;
		}  
		public void SomeMethod()
		{
			//use this.repo as needed
		}    
	}

	public interface IRepository
	{
		IEnumerable<CustomerDto> GetCustomers();
	}
	public EFRepository : IRepository
	{
		private YourDbContext db;
		private EFRepository()
		{
			db = new YourDbContext();
		}
		public IEnumerable<CustomerDto> GetCustomers()
		{
			return db.Customers.Select(f=>new CustomerDto { Id=f.Id, Name =f.Name}).ToList();
		}
	}
	public MockRepository : IRepository
	{
		public IEnumerable<CustomerDto> GetCustomers()
		{
			// to do : return a mock list of Customers
			// Or you may even use a mocking framework like Moq
		}
	}
}
