using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVSReadOnly
{
	class Program
	{
		public const int aTob = 100;//Compile time constant
		public static readonly int ro; // Runtime constant Can wait till runtime DEFAULT CONFIG

		static void Main(string[] args)
		{
			Console.WriteLine(aTob);
			Console.WriteLine(ro);
		}
	}
}
