using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class CommercialInputParameters
    {
        public PropertyType Type = PropertyType.Commercial;
//Address
        public int Village { get; set; }
        public int Region { get; set; }
        public int Street { get; set; }
        public string NumberAdress { get; set; }
        public string OperationType { get; set; }
        public float TotalArea { get; set; }


        //Details Info  
        public string TypeCommercial { get; set; }
        public string StateCommercial { get; set; }
        public string FloorCommercial { get; set; }
        public int TotalFloorCommercial { get; set; }
        public float EffectiveAreaCommercial { get; set; }
        public float LandAreaCommercial { get; set; }
        public int OficeNumber { get; set; }

        public int FloorMaterial { get; set; }
        public int WallMaterial { get; set; }

        //Additional Equipment 
        public bool Boiler { get; set; }
        public bool Intercom { get; set; }
        public bool Internet { get; set; }
        public bool CableTv { get; set; }
        public bool FirePlace { get; set; }
        public bool Air { get; set; }
        public bool Furniture { get; set; }
        public bool Signaling { get; set; }
        public bool SatelliteTv { get; set; }
        public bool MyWindows { get; set; }
        public bool Telephone { get; set; }
        public bool WashingMachine { get; set; }

        //communications
        public bool Gas { get; set; }
        public bool RailWay { get; set; }
        public bool CentralSewerage { get; set; }
        public bool CentralWater { get; set; }
        public bool CentralHeating { get; set; }
        public bool Electricity { get; set; }
        public bool AutonomousSewerage { get; set; }
        public bool AutonomusHeating { get; set; }
        public bool AutonomousWater { get; set; }

        //Describes object
        public string CaptionLink { get; set; }
        public string InfoDetails { get; set; }
  //Money
        public int GrnPrice { get; set; }
        public int DollarPrice { get; set; }
    }
}
