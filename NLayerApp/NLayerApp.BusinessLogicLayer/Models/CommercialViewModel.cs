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
        public int Id { get; set; }
        public string Region { get; set; }
        public string Village { get; set; }
        public string CaptionLink { get; set; }
        public string OperationType { get; set; }
        public string StateCommercial { get; set; }
        public double TotalArea { get; set; }
        public int TotalFloorCommercial { get; set;}
        public string FloorCommercial { get; set; }
        public int DollarPrice{ get; set; }
        public int GrnPrice{ get; set; }
    }
}
