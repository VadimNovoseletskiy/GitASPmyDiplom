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
    public class LandInputController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: LandInput
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Index(LandInputParameters parameters)
        {
            LandHandlerInput myHandlerInput=new LandHandlerInput(unitOfWork);
            myHandlerInput.InsertLand(parameters);
            myHandlerInput.SaveObject();
            return View();

        }
    }
}