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
    public class AdministratorHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public AdministratorHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public AdministratorHandler() : this(new UnitOfWork())
        {

        }

        public List<AdminAllObjectViewModel> GetAllObject() =>
            this.unitOfWork.GenericRepository<Info>()
                .Get()
                .Where(s => s.Type == PropertyType.Apartment
                            || s.Type == PropertyType.Commercial
                            || s.Type == PropertyType.House
                            || s.Type == PropertyType.Land)
                .Select(
                    s => new AdminAllObjectViewModel
                    {
                        Id = s.Id,
                        OperationType = s.OperationType,
                        Village = s.Village.VillageName,
                        Street = s.Street.StreetName,
                        AdressNumber = s.AddressNumber
                    }
                )
                .ToList<AdminAllObjectViewModel>();
    }
}
