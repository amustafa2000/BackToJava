using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassing
{
	class ParameterPassingTest
	{
		static void Main(string[] args)
		{
			ParamPassTest tests = new ParamPassTest();
			String forOut = "Before";
			String forOut2;
			String returned = "retBefore";
			String refParam = "This a refParam";
			String refParam2 = "This a refParam2";
			Console.WriteLine("forOut Before = " + forOut);
			Console.WriteLine("returned Before = " + returned);
			Console.WriteLine("refParam Before = " + refParam);

			returned = tests.test(out forOut, "First", "Second", out forOut2, ref refParam, ref refParam2);
			Console.WriteLine("forOut After = " + forOut);
			Console.WriteLine("forOut2 After = " + forOut2);
			Console.WriteLine("returned After = " + returned);
			Console.WriteLine("refParam After = " + refParam);
			Console.ReadKey();
		}

	
	}
	public class ParamPassTest
	{
		public ParamPassTest()
		{

		}

		public String test(out string forOut, string s, string y, out string forOut2, ref String refParam, ref String refParam2)
		{
			Console.WriteLine("got this s = " + s);
			Console.WriteLine("got this y = " + y);
			forOut = "Changed forOut";
			forOut2 = "Changed forOut2";
			refParam = "Not output, But changed!!!!!!!";
			return "xxxx";
		}
	}

}
