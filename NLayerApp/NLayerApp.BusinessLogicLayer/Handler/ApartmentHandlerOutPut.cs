using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;


namespace NLayerApp.BusinessLogicLayer.Handler
{

    public class ApartmentHandlerOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public ApartmentHandlerOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ApartmentHandlerOutPut() : this(new UnitOfWork())
        {

        }

    }
}