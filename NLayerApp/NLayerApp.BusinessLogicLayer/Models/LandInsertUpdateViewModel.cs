using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class LandInsertUpdateViewModel
    {
        public int Id { get; set; }
        
        //Address
        public int Village { get; set; }
        public int Region { get; set; }
        public int Street { get; set; }
        public string NumberAdress { get; set; }
        public double TotalArea { get; set; }
        public string CadastraNummber { get; set; }
        //land information
        public string OperationType { get; set; }
        public string TypeLand { get; set; }
        //communications
        public bool Gas { get; set; }
        public bool RailWay { get; set; }
        public bool CentralSewerage { get; set; }
        public bool CentralWater { get; set; }
        public bool CentralHeating { get; set; }
        public bool Electricity { get; set; }
        //Describes object
        public string CaptionLink { get; set; }
        public string InfoDetails { get; set; }
        //Money
        public int GrnPrice { get; set; }
        public int DollarPrice { get; set; }

    }
}
