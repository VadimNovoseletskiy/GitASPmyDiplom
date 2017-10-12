using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using RegionHandler = NLayerApp.WEB.Handler.RegionHandler;
using VillageHandler = NLayerApp.WEB.Handler.VillageHandler;

namespace NLayerApp.WEB.Controllers
{
   
    public class LandController : Controller
    {
        
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: Land
        [HttpGet]
        public ActionResult Index()
        {
           MySelect();

           return View();
        }
        
        //POST:Land 
        [HttpPost]
        public ActionResult Index(LandSearchParameters parameters)
        {
            MySelect();

            LandHandlerOutPut myLandHandlerOutPut = new LandHandlerOutPut(unitOfWork);

            var resultLand = myLandHandlerOutPut.GetInformation(parameters);
            return View(resultLand);
          
        }

        void MySelect()
        {
            RegionHandler myRegionHandler = new RegionHandler(unitOfWork);
            var resultRegion = myRegionHandler.GetRegion();
            SelectList listRegion = new SelectList(resultRegion, "Id", "Value");
            ViewBag.regionName = listRegion;

            VillageHandler myVillageHandler = new VillageHandler(unitOfWork);
            var resultVillage = myVillageHandler.GetVillage();
            SelectList listVillage = new SelectList(resultVillage, "Id", "Value");
            ViewBag.villageName = listVillage;

        }
    }
}