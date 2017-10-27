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
    public class DictionaryStreetController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: DictionaryStreet
        [HttpGet]
        public ActionResult Index()
        {
            DictionaryStreetHandler myStreetHandler=new DictionaryStreetHandler(unitOfWork);
            var result = myStreetHandler.GetStreet();
            return View(result);
        }
        //POST 
        [HttpPost]
        public ActionResult Index(StreetInputParameters parameters)
        {
            DictionaryStreetHandler myStreetHandler = new DictionaryStreetHandler(unitOfWork);
            myStreetHandler.InsertStreet(parameters);
            return RedirectToAction("Index");
        }
        //Get Edit
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DictionaryStreetHandler myStreetHandler = new DictionaryStreetHandler(unitOfWork);
            var result=myStreetHandler.StreetFind(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }
        //Post Edit 
        [HttpPost]
        public ActionResult Edit(Street street)
        {
            DictionaryStreetHandler myStreetHandler = new DictionaryStreetHandler(unitOfWork);
            if (ModelState.IsValid)
            {
                myStreetHandler.StreetUpdate(street);
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
            DeleteStreetDictionaryHandler myHandler = new DeleteStreetDictionaryHandler(unitOfWork);
            var street = myHandler.DeleteStreetDictionaryFind(id);

            if (street == null)
            {
                return HttpNotFound();
            }
            return View(street);
        }

        //Post Delete 
        [HttpPost]
        public ActionResult Delete(int id)
        {
            DeleteStreetDictionaryHandler myHandler = new DeleteStreetDictionaryHandler(unitOfWork);

            if (ModelState.IsValid)
            {
                myHandler.DeleteFindStreetDictionary(id);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}