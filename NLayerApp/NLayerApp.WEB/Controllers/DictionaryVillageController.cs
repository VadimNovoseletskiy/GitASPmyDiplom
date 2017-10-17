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
    public class DictionaryVillageController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: DictionaryVillage
        [HttpGet]
        public ActionResult Index()
        {
            DictionaryVillageHandler myDictionaryVillageHandler=new DictionaryVillageHandler(unitOfWork);
            var result = myDictionaryVillageHandler.GetVillages();

            return View(result);
        }

        //POST
        [HttpPost]
        public ActionResult Index(VillageInputParameters parameters)
        {
            DictionaryVillageHandler myDictionaryVillageHandler = new DictionaryVillageHandler(unitOfWork);
            myDictionaryVillageHandler.InsertVillage(parameters);
            return RedirectToAction("Index");
        }

        //Get
        [HttpGet]
        public ActionResult Edit(int ? id)
        {
            if (id==null)
            {
                return new  HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DictionaryVillageHandler myDictionaryVillageHandler = new DictionaryVillageHandler(unitOfWork);

            var result = myDictionaryVillageHandler.FindVillage(id);
            if (result==null)
            {
                return HttpNotFound();
            }

            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(Village village)
        {
            DictionaryVillageHandler myDictionaryVillageHandler = new DictionaryVillageHandler(unitOfWork);
            if (ModelState.IsValid)
            {
                myDictionaryVillageHandler.UpdateViillage(village);
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}