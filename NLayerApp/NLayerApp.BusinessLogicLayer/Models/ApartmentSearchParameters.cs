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
        public int NumberOfRooms { get; set; }
        public int DollarPrice { get; set; }
        public int GrnPrice { get; set; }
    }
}
