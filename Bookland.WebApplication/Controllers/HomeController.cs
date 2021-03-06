﻿using Bookland.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookland.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
        [HttpGet]
        public ActionResult BuyBook()
        {
            var book = new Book();
            return View(book);
        }
        [HttpPost]
        public ActionResult BuyBook(Book book)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}