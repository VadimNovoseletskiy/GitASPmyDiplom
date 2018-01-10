using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.BusinessLogicLayer.Models;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class DeleteImageHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteImageHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        public DeleteImageHandler():this(new UnitOfWork())
        {

        }

        public DeleteImageViewModel DeleteFindImage(int? id) =>
            this.unitOfWork.GenericRepository<Picture>()
                .Get()
                .Where(x => x.Id == id)
                .Select(
                    x => new DeleteImageViewModel
                    {
                        Id = x.Id,
                        fotoName = x.Name,
                        Image = x.Image,
                        InfoId = x.InfoId.Value
                    }
                )
                .FirstOrDefault();

        public void DeleteImage(int id)
        {
            this.unitOfWork.GenericRepository<Picture>().Delete(id);
            this.unitOfWork.SaveChanges();
        }


    }
}
