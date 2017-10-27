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
    [Authorize]
    public class AdminApartmentController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork();

        // GET: AdminApartment
        [HttpGet]
        public ActionResult Index()
        {
            AdminApartmentHandler myHandler=new AdminApartmentHandler(unitOfWork);
            var admResult = myHandler.GetAllApartment();
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
        public ActionResult MyInsert(ApartmentInputParameters parameters)
        {
            MySelect();
            AdminApartmentHandler myHandler = new AdminApartmentHandler(unitOfWork);
            myHandler.InsertApartment(parameters);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            AdminApartmentHandler myHandler = new AdminApartmentHandler(unitOfWork);
            var result = myHandler.FindInfoApartment(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);

        }

        [HttpPost]
        public ActionResult Edit(ApartmentInsertUpdateViewModel viewModel)
        {
            AdminApartmentHandler myHandler = new AdminApartmentHandler(unitOfWork);
            if (ModelState.IsValid)
            {
                myHandler.UpdateInfoApartment(viewModel);
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
            DeleteApartmentHandler myHandler = new DeleteApartmentHandler(unitOfWork);
            var commercial = myHandler.DeleteFindApartment(id);

            if (commercial == null)
            {
                return HttpNotFound();
            }
            return View(commercial);
        }


        //Post Delete
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DeleteApartmentHandler myHandler = new DeleteApartmentHandler(unitOfWork);

            if (ModelState.IsValid)
            {
                myHandler.DeleteApartment(id);
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