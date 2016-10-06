using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC4Demo.Models;

namespace MVC4Demo.Controllers
{
    public class CountryController : Controller
    {
        //
        // GET: /Country/

        public ActionResult GetCountries()
        {
			Country country1 = new Country()
			{
				Id = 11,
				Name = "USA"
			};
			return View(country1);
        }

    }
}
