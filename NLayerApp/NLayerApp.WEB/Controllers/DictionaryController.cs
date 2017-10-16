using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.WEB.Controllers
{
    public class DictionaryController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: Dictionary
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // POST
        [HttpPost]
        public ActionResult Index(RegionInputParameters parameters)
        {
            DictionaryHandler myDictionaryHandler=new DictionaryHandler(unitOfWork);
            myDictionaryHandler.InsertRegion(parameters);
            myDictionaryHandler.SaveObject();
            return View();
        }
    }
}