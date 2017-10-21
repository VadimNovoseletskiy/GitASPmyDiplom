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
    public class DictionaryStreetHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public DictionaryStreetHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        public DictionaryStreetHandler() : this(new UnitOfWork())
        {

        }

        public List<StreetViewModel> GetStreet() =>
            this.unitOfWork.GenericRepository<Street>()
                .Get()
                .Select(
                    p => new StreetViewModel
                    {
                        Id = p.Id,
                        Street = p.StreetName
                    }
                )
                .ToList<StreetViewModel>();

        public void InsertStreet(StreetInputParameters parameters)
        {
            Street myStreet=new Street {StreetName = parameters.Street};
            this.unitOfWork.GenericRepository<Street>().InsertGraph(myStreet);
            this.unitOfWork.SaveChanges();
        }

        public Street StreetFind(object id) =>
            this.unitOfWork.GenericRepository<Street>().Find(id);

        public void StreetUpdate(Street street)
        {
            this.unitOfWork.GenericRepository<Street>().Update(street);
            this.unitOfWork.SaveChanges();
        }


    }
}
