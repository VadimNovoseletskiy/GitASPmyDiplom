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
    public class DictionatyRegionController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: DictionatyRegion
        [HttpGet]
        public ActionResult Index()
        {
            DictionaryRegionHandler myRegionHandler=new DictionaryRegionHandler(unitOfWork);
            var resultAllRegion = myRegionHandler.RegionOutPut();
            return View(resultAllRegion);
        }

        //POST
        [HttpPost]
        public ActionResult Index(RegionInputParameters parameters)
        {
            DictionaryRegionHandler myRegionHandler = new DictionaryRegionHandler(unitOfWork);
            myRegionHandler.InsertRegion(parameters);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DictionaryRegionHandler myRegionHandler = new DictionaryRegionHandler(unitOfWork);
            var region= myRegionHandler.Find(id);
           
            if (region == null)
            {
                return HttpNotFound();
            }
            return View(region);
           
        }

        [HttpPost]
        public ActionResult Edit(Region region)
        {
            DictionaryRegionHandler myRegionHandler = new DictionaryRegionHandler(unitOfWork);

            if (ModelState.IsValid)
            {
                myRegionHandler.Update(region);
                return RedirectToAction("Index");
                
            }
            return View();
        }
    }
}