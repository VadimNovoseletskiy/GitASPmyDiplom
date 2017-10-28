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
    public class ApartmentController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: Apartment
        [HttpGet]
        public ActionResult Index()
        {
            MySelect();
            return View();
        }

        //POST:Apartment
        [HttpPost]
        public ActionResult Index(ApartmentSearchParameters parameters)
        {
            MySelect();

            ApartmentHandlerOutPut myApartmentHandlerOutPut=new ApartmentHandlerOutPut(unitOfWork);
            var resultApartment = myApartmentHandlerOutPut.GetApartment(parameters);

            return View(resultApartment);
        }
        
        //Get Details Info
        [HttpGet]
        public ActionResult OutDetailsInfo(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailsInfoOutPutHandler myHandler = new DetailsInfoOutPutHandler(unitOfWork);
            var detailsInfo = myHandler.DetailsInfoObjectFind(id);

            if (detailsInfo==null)
            {
                return HttpNotFound();
            }
            return View(detailsInfo);

        }



        void MySelect()
        {
            RegionHandler myRegionHandler=new RegionHandler(unitOfWork);
            var resultRegion = myRegionHandler.GetRegion();
            SelectList listRegion=new SelectList(resultRegion,"Id","Value");
            ViewBag.regionName = listRegion;

            VillageHandler myVillageHandler=new VillageHandler();
            var resultVillage = myVillageHandler.GetVillage();
            SelectList listVillage=new SelectList(resultVillage,"Id","Value");
            ViewBag.villageName = listVillage;
        }


    }
}