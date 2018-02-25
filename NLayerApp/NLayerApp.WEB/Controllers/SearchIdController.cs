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
    public class SearchIdController : Controller
    {
            IUnitOfWork unitOfWork=new UnitOfWork();

        // GET: SearchId
        [HttpGet]
        public ActionResult Index(int ? id )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            SearchIdHandler idHand=new SearchIdHandler(unitOfWork);
            var result = idHand.TypeMyObjectFind(id);

            if (result == null)
            {
                return View();
            }

            if (result.MyType==PropertyType.Apartment)
            {
                
                var detailsInfo = idHand.DetailsInfoObjectFind(id);

                if (detailsInfo == null)
                {
                    return HttpNotFound();
                }
                return View(detailsInfo);
            }

            if (result.MyType == PropertyType.House)
            {
              
                var detailsInfo = idHand.DetailsInfoHouseFind(id);
                if (detailsInfo == null)
                {
                    return HttpNotFound();
                }
                return View(detailsInfo);
               
            }

            if (result.MyType==PropertyType.Commercial)
            {
               
                var detailsInfo = idHand.DetailsInfoCommercialFind(id);
                if (detailsInfo==null)
                {
                    return HttpNotFound();
                }

                return View(detailsInfo);
            }

            if (result.MyType==PropertyType.Land)
            {
               
                var detailsInfo = idHand.DetailsInfoLandFind(id);
                if (detailsInfo==null)
                {
                    return HttpNotFound();
                }

                return View(detailsInfo);
            }

            return View();
        }
    }
}