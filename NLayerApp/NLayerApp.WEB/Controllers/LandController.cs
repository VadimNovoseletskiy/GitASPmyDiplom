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
   
    public class LandController : Controller
    {
        MyContext dbContext=new MyContext();//test out put
        // GET: Land
        [HttpGet]
        public ActionResult Index()
        {
            IQueryable<Land> lands = dbContext.Land;//test out put
            ViewBag.land = lands;//test out put
            return View();
        }
        
        //POST:Land 
        [HttpPost]
        public ActionResult Index(LandSearchParameters parameters)
        {
            LandHandlerOutPut myLandHandlerOutPut = new LandHandlerOutPut();
            var resultLand = myLandHandlerOutPut.GetInformation(parameters);
            return View(resultLand);
          
        }
    }
}