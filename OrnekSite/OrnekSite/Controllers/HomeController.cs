﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekSite.Entity;

namespace OrnekSite.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Products.Where(i=>i.IsHome&&i.IsApproved).ToList());
        }
         
        public ActionResult ProductDetails(int id)
        {
            return View(db.Products.Where(i=>i.Id==id).FirstOrDefault());
        }
        public ActionResult Product()
        {
            return View(db.Products.ToList());
        }

    }
}