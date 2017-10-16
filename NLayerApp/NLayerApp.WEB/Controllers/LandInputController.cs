using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Handler;

namespace NLayerApp.WEB.Controllers
{
    public class LandInputController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: LandInput
        [HttpGet]
        public ActionResult Index()
        {
            MySelect();
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Index(LandInputParameters parameters)
        {
            MySelect();
            LandHandlerInput myHandlerInput=new LandHandlerInput(unitOfWork);
            myHandlerInput.InsertLand(parameters);
            myHandlerInput.SaveObject();
            return View();

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