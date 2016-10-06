﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
			List<string> stringList = new List<string>();
			stringList.Add("USA");
			stringList.Add("Bangladesh");
			ViewBag.Countries = stringList;
            return View();
        }

		public string XXXIndex()
		{
			return "Hello from MVC Appliation XXXX";
		}

    }
}
