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
    public class HouseController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: House
        [HttpGet]
        public ActionResult Index()
        {
            MySelect();
            return View();
        }


        //POST:House(form for search) 
        [HttpPost]
        public ActionResult Index(HouseSearchParameters parameters)
        {
            MySelect();
            HouseHandlerOutPut myHouseHandlerOutPut=new HouseHandlerOutPut(unitOfWork);
            var resultHouse = myHouseHandlerOutPut.GetHouse(parameters);

            return View(resultHouse);
        }

        //Get:House details Info
        [HttpGet]
        public ActionResult OutPutDetailsInfoHouse(int? id)
        {
            MySelect();
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetailsInfoOutPutHouseHandler myHandler=new DetailsInfoOutPutHouseHandler(unitOfWork);
            var detailsInfoHouse = myHandler.DetailsInfoHouseFind(id);
            if (detailsInfoHouse==null)
            {
                return HttpNotFound();
            }
            return View(detailsInfoHouse);

        }

        //Get details info about Land about Id 
        [HttpGet]
        public ActionResult IdOutPutDetaialsInfoHouse(int? id)
        {
            MySelect();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            DetailsInfoOutPutHouseHandler myHandler=new DetailsInfoOutPutHouseHandler(unitOfWork);
            var idDetailsInfo = myHandler.IdDetailsInfo(id);
            return View(idDetailsInfo);
        }

        void MySelect()
        {
            RegionHandler myRegionHandler=new RegionHandler(unitOfWork);
            var resultRegion = myRegionHandler.GetRegion();
            SelectList listRegion=new SelectList(resultRegion,"Id","Value");
            ViewBag.regionName = listRegion;

            VillageHandler myVillageHandler=new VillageHandler(unitOfWork);
            var resultVillage = myVillageHandler.GetVillage();
            SelectList listVillage=new SelectList(resultVillage, "Id", "Value");
            ViewBag.villageName = listVillage;
        }
    }
}