using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapClient
{
	class Program
	{
		static void Main(string[] args)
		{
			SoapWebserviceRef.RestWebservice obj = new SoapWebserviceRef.RestWebservice();
			Console.WriteLine(" Calling Web Methods");
			Console.WriteLine("---------------------");
			Console.WriteLine("\n Calling Hello World");
			Console.WriteLine("  " + obj.HelloWorld());
			Console.ReadLine();
		}
	}
}
