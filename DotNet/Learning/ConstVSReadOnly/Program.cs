using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVSReadOnly
{
	class Program
	{
		public static void Main(string[] args)
		{
			ReadOnlyTest rot = new ReadOnlyTest();
		}
	}

	class ReadOnlyTest
	{
		public readonly int roOne = 5;
		public const int conOne = 7;

		public ReadOnlyTest()
		{
			// Changing constant is not allowed
			//conOne = 9;
			roOne = 7;
		}
	}
}
