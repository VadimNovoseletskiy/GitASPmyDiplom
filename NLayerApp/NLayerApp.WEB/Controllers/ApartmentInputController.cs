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
    public class ApartmentInputController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork();

        // GET: ApartmentInput
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Index(ApartmentInputParameters parameters)
        {
            ApartmentHandlerInput myHandlerInput = new ApartmentHandlerInput(unitOfWork);
            myHandlerInput.InsertApartment(parameters);
            myHandlerInput.SaveObject();
            return View();
        }


    }
}