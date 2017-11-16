using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Handler;

namespace NLayerApp.WEB.Controllers
{
    public class AdminCommercialController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork();

        // GET: AdminCommercial
        [HttpGet]
        public ActionResult Index()
        {
            AdminCommercialHandler myHandler = new AdminCommercialHandler(unitOfWork);
            var admResult = myHandler.GetAllCommercial();
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
        public ActionResult MyInsert(CommercialInputParameters parameters)
        {
            MySelect();
            AdminCommercialHandler myHandler = new AdminCommercialHandler(unitOfWork);
            myHandler.InsertCommercial(parameters);

            return RedirectToAction("Index");

        }

        //Get Edit
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            AdminCommercialHandler myHandler = new AdminCommercialHandler(unitOfWork);
            var result = myHandler.FindInfoCommercial(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);

        }

        //Post Edit
        [HttpPost]
        public ActionResult Edit(CommercialInsertUpdateViewModel viewModel)
        {
            MySelect();
            AdminCommercialHandler myHandler = new AdminCommercialHandler(unitOfWork);
            if (ModelState.IsValid)
            {
                myHandler.UpdateInfoCommercial(viewModel);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Get Delete
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeleteCommercialHandler myHandler = new DeleteCommercialHandler(unitOfWork);
            var land = myHandler.DeleteFindCommercial(id);

            if (land == null)
            {
                return HttpNotFound();
            }
            return View(land);
        }


        //Post Delete
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DeleteCommercialHandler myHandler = new DeleteCommercialHandler(unitOfWork);

            if (ModelState.IsValid)
            {
                myHandler.DeleteCommercial(id);
                return RedirectToAction("Index");
            }
            return View("Index");
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