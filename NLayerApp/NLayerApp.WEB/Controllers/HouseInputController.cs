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
    public class HouseInputController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: HouseInput
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Index(HouseInputParameters parameters)
        {
            HouseHandlerInput myHandlerInput=new HouseHandlerInput(unitOfWork);
            myHandlerInput.InsertHouse(parameters);
            myHandlerInput.SaveObject();
            return View();
        }
    }
}