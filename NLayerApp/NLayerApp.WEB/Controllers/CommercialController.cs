using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.WEB.Controllers
{
    public class CommercialController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: Commercial
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}