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
    public class DictionaryWallMaterialController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork();
        // GET: DictionaryWallMaterial
        [HttpGet]
        public ActionResult Index()
        {
            DictionaryWallMaterialHandler myHandler = new DictionaryWallMaterialHandler(unitOfWork);
            var resultWallMaterial = myHandler.GetWallMaterial();
            return View(resultWallMaterial);
        }

        [HttpPost]
        public ActionResult Index(WallMaterialInputParemeters paremeters)
        {
            DictionaryWallMaterialHandler myHandler = new DictionaryWallMaterialHandler(unitOfWork);
            myHandler.InsertWallMaterial(paremeters);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DictionaryWallMaterialHandler myHandler = new DictionaryWallMaterialHandler(unitOfWork);
            var result = myHandler.FindWallMaterial(Id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(WallMaterial wallMaterial)
        {
            DictionaryWallMaterialHandler myHandler = new DictionaryWallMaterialHandler(unitOfWork);
            if (ModelState.IsValid)
            {
                myHandler.UpdateWallMaterial(wallMaterial);
                return RedirectToAction("Index");
            }
            return View();
        }

    
    }
}