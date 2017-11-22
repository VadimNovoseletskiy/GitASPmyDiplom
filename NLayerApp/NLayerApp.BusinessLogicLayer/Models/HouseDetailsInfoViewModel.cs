using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class HouseDetailsInfoViewModel
    {
        public int Id { get; set; }

        //Address
        public string Village { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string NumberAdress { get; set; }
        public string OperationType { get; set; }

        //Details Info  
        public string TypeHouse { get; set; } //
        public string ReadinessHouse { get; set; }
        public string PartHouse { get; set; } //
        public string ConditionHouse { get; set; }
        public int RoomsHouse { get; set; } //
        public int FloorHouse { get; set; } //
        public string FloorMaterial { get; set; }
        public string WallMaterial { get; set; }
        public double TotalAreaInfo { get; set; }
        public float LivingAreaHouse { get; set; } //
        public float KitchenAreaHouse { get; set; } //
        public float LandAreaHouse { get; set; } //

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

        //OutBuildings
        public bool BahtHouse { get; set; }
        public bool Swimming { get; set; }
        public bool Garage { get; set; }
        public bool Well { get; set; }
        public bool SummerKitchen { get; set; }
        public bool WorkShop { get; set; }
        public bool Barn { get; set; }
        public bool Well1 { get; set; }
        public bool GreenHouse { get; set; }


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
        public string NameInfo { get; set; }
        public string InfoDetails { get; set; }
       
        //Money
        public int GrnPrice { get; set; }
        public int DollarPrice { get; set; }
    }
}
