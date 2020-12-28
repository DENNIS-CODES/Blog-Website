using System;
using System.Collections.Generic;
using System.linq;
using System.web;
using System.web.mvc;

namespace Blog_Website_MVC.Controllers
{
    public class BLogController : Controller
    {
        // GET: Blog
        public ActionResult index()
        {
            return View();
        }

        public ActionResult Uploadblog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Uploadblog(Blog bg)
        {
            newdbEntities nd = new newdbEntities();
            nd.Blogs.Add(bg);
            nd.SaveChanges();
            ViewBag.message = "Blog Details Are Saved Successfully..!";
            return View();
        }
    }
}