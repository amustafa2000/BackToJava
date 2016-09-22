using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeGC
{
	class TypeGCProgram
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog();
			dog.SetBug(new Bug());
			Type t1 = dog.GetType();
			var property = t1.GetProperty("zip");
			//var pValue = property.GetValue(dog, null);
			var properties = t1.GetProperties();

			//??????????? is type an Object
			Console.WriteLine("Is type object? = " + (t1 is object));

			Dog activatorDog = (Dog)Activator.CreateInstance<Dog>();
			Dog dog2 = new Dog(20000);

			var constructors = typeof (Dog).GetConstructors();
			var legConstructor = typeof(Dog).GetConstructor(new[] { typeof(int) });
			object[] parameters = new object[] { 1123 };
			var advancedDog = (Dog)legConstructor.Invoke(parameters);
			advancedDog.GetBug();

			Console.WriteLine(dog is Animal);
			Console.WriteLine(dog is Dog);


			// *** Auto disposible *** using USING
			using (DisposibleExample de = new DisposibleExample())
			{

				// Using will call Disposer()
			}
			// *** Manual dispose ***
			DisposibleExample de2 = new DisposibleExample();
			de2.Dispose();

	
			Console.ReadKey();
		}
	}

	public class DisposibleExample : IDisposable
	{
		public DisposibleExample()
		{

		}
		public void Dispose()
		{
			// puts it in the trash can
			Console.WriteLine("Dispose is invoked");
		}
	}

	public class Bug
	{
	}
	public class Animal
	{
		
	}
	public class Dog : Animal
	{
		public int zip;
		private Bug bug;
		public Dog()
		{
			this.zip = 10000;
		}
		public Dog(int zip = 10000)
		{
			this.zip = zip;
		}
		public int GetZip()
		{
			return zip;
		}
		public void SetBug(Bug bug)
		{
			this.bug = bug;
		}
		public Bug GetBug()
		{
			return bug;
		}
	}
}
