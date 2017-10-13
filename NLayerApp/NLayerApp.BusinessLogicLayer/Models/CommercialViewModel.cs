using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class CommercialViewModel
    {
        public string Region { get; set; }
        public string Village { get; set; }
        public string StateCommercial { get; set; }
        public float TotalArea { get; set; }
        public int DollarPrice{ get; set; }
        public int GrnPrice{ get; set; }
    }
}
