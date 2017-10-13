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
        //MyContext dbContext=new MyContext();
        public ActionResult Index()
        {
           // IQueryable<Village> villages = dbContext.Villages;
            //ViewBag.vill = villages;
            return View();
        }





       

        public ActionResult CommercialForm()
        {
            return View();
        }

       


        public ActionResult InputApartmentForm()
        {
            return View();
        }

        public ActionResult InputHouseForm()
        {
            return View();
        }

        public ActionResult InputCommercialForm()
        {
            return View();
        }

        public ActionResult InputLandForm()
        {
            return View();
        }



    }
}