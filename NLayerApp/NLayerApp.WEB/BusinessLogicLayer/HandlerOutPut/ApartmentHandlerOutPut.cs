using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;
using NLayerApp.WEB.Models;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class ApartmentHandlerOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public ApartmentHandlerOutPut(IUnitOfWork unitOfWork)
        {this.unitOfWork = unitOfWork;}

        public ApartmentHandlerOutPut() : this(new UnitOfWork()){}

        public IEnumerable<ApartmentViewModel> GetApartments() =>
            this.unitOfWork.GenericRepository<Apartment>().Get().AsEnumerable().Select(this.Convert);

        public ApartmentViewModel GetApartment(int id) =>
         this.Convert(this.unitOfWork.GenericRepository<Apartment>().Find(id));

        public ApartmentViewModel Convert(Apartment apartment) =>

         new ApartmentViewModel
         {             };
    }
}
