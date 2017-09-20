using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Interface;
using NLayerApp.DataAccessLayer.Repository;

namespace NLayerApp.BusinessLogicLayer.Handler
{
    public class CommercialHandlerOutPut
    {
        private readonly IUnitOfWork unitOfWork;

        public CommercialHandlerOutPut(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public CommercialHandlerOutPut() : this(new UnitOfWork())
        {
            
        }
    }
}
