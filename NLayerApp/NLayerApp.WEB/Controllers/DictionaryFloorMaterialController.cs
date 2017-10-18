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

        [HttpPost]
        public ActionResult Index(FloorMaterialInputParametrs parametrs)
        {
            DictionaryFloorMaterialHandler myHandler = new DictionaryFloorMaterialHandler(unitOfWork);
            myHandler.InsertFloorMaterial(parametrs);
            return RedirectToAction("Index");
        }

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


    }
}