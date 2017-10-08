using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;

namespace NLayerApp.WEB.Controllers
{
    public class LandController : Controller
    {
        // GET: Land
        [HttpGet]
        public ActionResult Index()
        {
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