using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Handler;

namespace NLayerApp.WEB.Controllers
{
    public class AdminImageController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        [HttpGet]
        public ActionResult Index(int ? id )
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminImageHandler myObjectInfo=new AdminImageHandler(unitOfWork);
           
            var admResult=myObjectInfo.GetAllImages(id);

            return View(admResult);
        }



        //Get
        [HttpGet]
        public ActionResult InsertImages(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.InfoId = id;

            return View();
        }

        //POST
        [HttpPost]
        public ActionResult InsertImages(ImageParameters parameters, HttpPostedFileBase uploadImage)
        {
            MySelect();
            AdminImageHandler myHandler = new AdminImageHandler(unitOfWork);
            if (uploadImage != null)
            {
                byte[] imageData = null;

                //считывыем переданный файл в массив байтов 
                using (var binaryReader = new BinaryReader(uploadImage.InputStream))
                {
                    imageData = binaryReader.ReadBytes(uploadImage.ContentLength);
                }
                parameters.Image = imageData;
                myHandler.InsertImage(parameters);
                //return RedirectToAction("InsertImages");

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