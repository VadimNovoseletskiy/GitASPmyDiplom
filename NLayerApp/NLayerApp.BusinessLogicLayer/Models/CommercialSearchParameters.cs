using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class CommercialSearchParameters
    {
        public int Region { get; set; }
        public int Village { get; set; }
        public TypeOfOperation TypeOperation { get; set; }
        public SpecialTypeCommercial TypeCommercial { get; set; }
        public int DollarPriceFrom { get; set; }
        public int DollarPriceTo { get; set; }
        public int GrnPriceFrom { get; set; }
        public int GrnPriceTo { get; set; }
    }
}
