﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _00Northwind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //這是Action，不是函數 
        {
            return View();
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}


//SQL資料檔存.mdf
//另一個是LOG檔