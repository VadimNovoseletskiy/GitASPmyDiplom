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

namespace NLayerApp.WEB.Controllers
{
    public class DictionaryFloorMaterialController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: DictionaryFloorMaterial
        [HttpGet]
        public ActionResult Index()
        {
            DictionaryFloorMaterialHandler myHandler = new DictionaryFloorMaterialHandler(unitOfWork);
            var materials = myHandler.GetFloorMaterial();
            return View(materials);
        }
        //POST
        [HttpPost]
        public ActionResult Index(FloorMaterialInputParametrs parametrs)
        {
            DictionaryFloorMaterialHandler myHandler = new DictionaryFloorMaterialHandler(unitOfWork);
            myHandler.InsertFloorMaterial(parametrs);
            return RedirectToAction("Index");
        }
        //Get Edit
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            DictionaryFloorMaterialHandler myHandler = new DictionaryFloorMaterialHandler(unitOfWork);
            if (id == null)
            {
                return  new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
                var material=myHandler.FindFloorMaterial(id);
            if (material==null)
            {
                return HttpNotFound();
            }
            return View(material);

        }

        //Post Edit
        [HttpPost]
        public ActionResult Edit(FloorMaterial floorMaterial)
        {
            DictionaryFloorMaterialHandler myHandler = new DictionaryFloorMaterialHandler(unitOfWork);

            if (ModelState.IsValid)
            {
                myHandler.UpddateFloorMaterial(floorMaterial);
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
            DeleteFloorMaterialDictionatyHandler myHandler = new DeleteFloorMaterialDictionatyHandler(unitOfWork);
            var fMaterial = myHandler.DeleteFloorMaterialDictionaryFind(id);

            if (fMaterial == null)
            {
                return HttpNotFound();
            }
            return View(fMaterial);
        }

        //Post Delete 
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DeleteFloorMaterialDictionatyHandler myHandler = new DeleteFloorMaterialDictionatyHandler(unitOfWork);

            if (ModelState.IsValid)
            {
                myHandler.DeleteFindFloorMaterialDictionary(id);
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}