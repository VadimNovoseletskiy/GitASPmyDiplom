using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.DataAccessLayer.Domains;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.WEB.Controllers
{
    public class HomeController : Controller
    {
        MyContext dbContext=new MyContext();
        public ActionResult Index()
        {
            IQueryable<Village> villages = dbContext.Villages;
            ViewBag.vill = villages;
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