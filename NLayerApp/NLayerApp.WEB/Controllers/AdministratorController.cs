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
    [Authorize]
    public class AdministratorController : Controller
    {
        IUnitOfWork unitOfWork = new UnitOfWork();
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }
        
        
    }
}