using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Handler;

namespace NLayerApp.WEB.Controllers
{
    [Authorize]
    public class AdminLandController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork();
        
        // GET: AdminLand
        [HttpGet]
        public ActionResult Index()
        {
            AdminLandHandler myAdminLandHandler=new AdminLandHandler(unitOfWork);
            var admResult = myAdminLandHandler.GetAllLand();

            return View(admResult);
        }

        //Get
        [HttpGet]
        public ActionResult MyInsert()
        {
            MySelect();
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult MyInsert(LandInputParameters parameters)
        {
            MySelect();
            LandHandlerInput myHandlerInput = new LandHandlerInput(unitOfWork);
            myHandlerInput.InsertLand(parameters);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {    MySelect();
            if (id == null)
            {
                return  new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            AdminLandHandler myAdminLandHandler = new AdminLandHandler(unitOfWork);
            var result= myAdminLandHandler.FindInfoLand(id);
            if (result==null)
            {
                return HttpNotFound();
            }
            return View(result);

        }

        [HttpPost]
        public ActionResult Edit(LandInsertUpdateViewModel viewModel)
        {
            AdminLandHandler myAdminLandHandler = new AdminLandHandler(unitOfWork);
            if (ModelState.IsValid)
            {
                myAdminLandHandler.UpdateInfoLand(viewModel);
                return RedirectToAction("Index");
            }
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

            StreetHandler myStreetHandler = new StreetHandler(unitOfWork);
            var resultStreet = myStreetHandler.GetStreet();
            SelectList listStreet = new SelectList(resultStreet, "Id", "Value");
            ViewBag.streetName = listStreet;

            FloorMaterialHandler myFloorMaterialHandler = new FloorMaterialHandler(unitOfWork);
            var resultFloorMaterial = myFloorMaterialHandler.GetFloorMaterial();
            SelectList listFoorMaterial = new SelectList(resultFloorMaterial, "Id", "Value");
            ViewBag.floorMaterialName = listFoorMaterial;

            WallMaterialHandler myWallMaterialHandler = new WallMaterialHandler(unitOfWork);
            var resultWallMaterial = myWallMaterialHandler.GetWallMaterial();
            SelectList listWallMaterial = new SelectList(resultWallMaterial, "Id", "Value");
            ViewBag.wallMaterialName = listWallMaterial;
        }
    }
}