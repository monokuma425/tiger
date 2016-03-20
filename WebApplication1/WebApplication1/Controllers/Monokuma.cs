using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MonokumaController : Controller
    {
        //
        // GET: /monokuma/
        public ActionResult Index()
        {
            return View();
        }
        public string Metod()
        {
            return "blablabla";
        }
        public string Welcome(string name, int count)
        {
            return string.Format("Hello, {0}, count {1}", name, count);
        }
        public ActionResult Drak(string name, int count)
        {
            ViewBag.Message = "blablabla";
            ViewBag.name = name;
            ViewBag.count = count;
            return View();
        }
        public ActionResult GetTiger()
        {
            var tiger = new Tiger();
            tiger.color = "white";
            tiger.age = 5;
            tiger.area = "India";
            tiger.extinction = true;
            tiger.name = "Tigra";
            return View(tiger);
        }
	}

}