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
    public class CommercialInputController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: CommercialInput
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        //POST
        [HttpPost]
        public ActionResult Index(CommercialInputParameters parameters)
        {
            CommercialHandlerInput myHandlerInput=new CommercialHandlerInput(unitOfWork);
            myHandlerInput.InsertCommercial(parameters);
            myHandlerInput.SaveObject();
            return View();
        }

    }
}