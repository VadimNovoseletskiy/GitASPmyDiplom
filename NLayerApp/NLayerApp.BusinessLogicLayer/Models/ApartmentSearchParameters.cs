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
        public SpecialTypeRoom TypeRoom { get; set; }
        public TypeOfOperation OperationType { get; set; }
        public int NumberOfRooms { get; set; }
        public int DollarCostFrom { get; set; }
        public int DollarCostTo { get; set; }
        public int GrnCostFrom { get; set; }
        public int GrnCostTo { get; set; }
        public string NameInfo { get; set; }
    }
}
