using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class ApartmentSearchParameters
    {
        public int Region { get; set; }
        public int Village { get; set; }
        public string TypeRoom { get; set; }
        public string OperationType { get; set; }
        public string RoomsApartment { get; set; }
        public int DollarCostTo { get; set; }
        public int GrnCostTo { get; set; }
    }
}
