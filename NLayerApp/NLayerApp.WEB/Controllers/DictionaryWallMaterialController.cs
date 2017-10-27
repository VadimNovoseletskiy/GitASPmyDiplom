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
        //POST 
        [HttpPost]
        public ActionResult Index(WallMaterialInputParemeters paremeters)
        {
            DictionaryWallMaterialHandler myHandler = new DictionaryWallMaterialHandler(unitOfWork);
            myHandler.InsertWallMaterial(paremeters);
            return RedirectToAction("Index");
        }
        //Get Edit
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
        //Post Edit
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

        //Get Delete 
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeleteWallmaterialDictionaryHandler myHandler = new DeleteWallmaterialDictionaryHandler(unitOfWork);
            var wmaterial = myHandler.DeleteWallrMaterialDictionaryFind(id);

            if (wmaterial == null)
            {
                return HttpNotFound();
            }
            return View(wmaterial);
        }

        //Post Delete 
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DeleteWallmaterialDictionaryHandler myHandler = new DeleteWallmaterialDictionaryHandler(unitOfWork);

            if (ModelState.IsValid)
            {
                myHandler.DeleteFindWallMaterialDictionary(id);
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}