using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeExample
{
	class TypeExampleProgram
	{
		static void Main(string[] args)
		{
			var bird = new Animal<Egg>();
			var pig = new Animal<Piglet>();
		}
	}

	public class Animal<T> where T : Offspring
	{
		public T Offspring { get; set; }
	}

	public abstract class Offspring { }
	public class Egg : Offspring { }
	public class Piglet : Offspring { }
}
