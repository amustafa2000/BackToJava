using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog();
			Dog dog2 = new Dog(20000);
			Type t1 = dog.GetType();

			Console.WriteLine(dog is Animal);
			Console.WriteLine(dog is Dog);
			Console.ReadKey();
		}
	}

	public class Animal
	{
		
	}
	public class Dog : Animal
	{
		private int zip;
		public Dog(int zip = 10000)
		{
			this.zip = zip;
		}
		public int GetZip()
		{
			return zip;
		}
	}
}
