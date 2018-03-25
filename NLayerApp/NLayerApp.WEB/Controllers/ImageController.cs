using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLayerApp.BusinessLogicLayer.Handler;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.WEB.Controllers
{
    public class ImageController : Controller
    {
        IUnitOfWork unitOfWork=new UnitOfWork();
        // GET: Thumbnail
        public ActionResult Thumbnail(int ? id )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            GetThumpnailHandler myHandler=new GetThumpnailHandler(unitOfWork);
            var result = myHandler.Execute(id);

            if (result == null)
            {
                return HttpNotFound();
            }

            return File(result.Image, MimeMapping.GetMimeMapping(result.Name), result.Name);
        }

        // GET: Index
        public ActionResult Index(int ? id )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var myHandler= new GetImageHandler(unitOfWork);
            var result = myHandler.Execute(id);

            if (result == null)
            {
                return HttpNotFound();
            }

            return File(result.Image, MimeMapping.GetMimeMapping(result.Name), result.Name);
        }
    }
}