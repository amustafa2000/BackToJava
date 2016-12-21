using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Link_DB
{
	class Program
	{
		static void Main(string[] args)
		{
			CountryCityContext context = new CountryCityContext();
			IEnumerable<Country> c = context.Countries.Where(x => x.Code == "ESP");
			foreach (Country item in c)
			{
				Console.WriteLine("Using Inline = " + item.Name);
			}
			
			// Get all countries
			List<Country> allContries = context.Countries.ToList();
			IEnumerable<Country> allCountriesSQl = from x in allContries
												  select x;
			foreach (Country cc in allCountriesSQl)
			{
				Console.WriteLine("Using Inline = " + cc.Code);
			}
			Console.ReadKey();
		}
	}
}
