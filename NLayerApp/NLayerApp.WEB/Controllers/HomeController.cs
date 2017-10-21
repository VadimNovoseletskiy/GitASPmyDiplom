using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.WEB.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
          
            return View();
        }


        public ActionResult Services()
        {
            return View();
        }

       

        public ActionResult MyAbout()
        {
            return View();
        }

        public ActionResult MyContact()
        {
            return View();
        }

        public ActionResult Kredit()
        {
            return View();
        }




    }
}