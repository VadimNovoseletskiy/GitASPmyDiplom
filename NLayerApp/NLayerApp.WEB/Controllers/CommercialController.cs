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
    public class CommercialController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: Commercial
        [HttpGet]
        public ActionResult Index()
        {
            MySelect();
            CommercialHandlerAllOutPut myOutPut=new CommercialHandlerAllOutPut(unitOfWork);
            var result = myOutPut.GetAllCommercial();
            return View(result);
        }

        [HttpPost]
        public ActionResult Index(CommercialSearchParameters parameters)
        {
            MySelect();
            CommercialHandlerOutPut myCommercialHandlerOutPut=new CommercialHandlerOutPut(unitOfWork);
            var resultCommercial = myCommercialHandlerOutPut.GetCommercial(parameters);
            return View(resultCommercial);
        }

        [HttpGet]
        public ActionResult OutPutDetailsInfoCommercial(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailsInfoOutPutCommercialHandler myHandler=new DetailsInfoOutPutCommercialHandler(unitOfWork);
            var detailsOutInfoCommercial = myHandler.DetailsInfoCommercialFind(id);
            if (detailsOutInfoCommercial == null)
            {
                return HttpNotFound();
            }
            return View(detailsOutInfoCommercial);
        }

        //Get Details info about object by Id
        [HttpGet]
        public ActionResult IdOutPutDetailsInfo(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailsInfoOutPutCommercialHandler myHandler = new DetailsInfoOutPutCommercialHandler(unitOfWork);
            var idDetailsOutInfoCommercial = myHandler.IdOutPutDetailsInfo(id);
           
            return View(idDetailsOutInfoCommercial);
        }

        void MySelect()
        {
            RegionHandler myRegionHandler=new RegionHandler(unitOfWork);
            var resultRegion = myRegionHandler.GetRegion();
            SelectList listRegion=new SelectList(resultRegion,"Id","Value");
            ViewBag.regionName = listRegion;

            VillageHandler myVillageHandler=new VillageHandler(unitOfWork);
            var resultVillage = myVillageHandler.GetVillage();
            SelectList listVillage=new SelectList(resultVillage,"Id", "Value");
            ViewBag.villageName = listVillage;

           
        }
    }
}