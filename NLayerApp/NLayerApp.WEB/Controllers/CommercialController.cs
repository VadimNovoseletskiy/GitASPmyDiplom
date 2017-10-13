using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerApp.WEB.Controllers
{
    public class CommercialController : Controller
    {

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