using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
	class EventExampleProgram
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog();
			dog.Barked += dog_Barked;
			dog.Bark();
			//Important release the handle FREE in For GARBAGE Collection
			dog.Barked -= dog_Barked;
			Console.ReadKey();
		}

		static void dog_Barked(object sender, EventArgs e)
		{
			//throw new NotImplementedException();
			Console.WriteLine("Barkied");
		}
	}

	class Dog
	{
		public event EventHandler Barked;
		public void Bark()
		{
			Console.WriteLine("Barking");
			if (Barked != null)
			{
				Barked(this, EventArgs.Empty);
			}
		}
	}
}
