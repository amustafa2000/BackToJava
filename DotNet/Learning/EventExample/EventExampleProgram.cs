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
		}

		static void dog_Barked(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}

	class Dog
	{
		public event EventHandler Barked;


		public void Bark()
		{
			if (Barked != null)
			{
				Barked(this, EventArgs.Empty);
			}
		}
	}



}
