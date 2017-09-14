using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class CommercialHandler
    {
        private readonly IUnitOfWork unitOfWork;

        public CommercialHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public CommercialHandler() : this(new UnitOfWork())
        {
        }
    }
}
