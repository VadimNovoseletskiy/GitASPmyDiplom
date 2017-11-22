using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
     public class ApartmentInsertUpdateViewModel
    {
        public int Id { get; set; }

        //Address
        public int Village { get; set; }
        public int Region { get; set; }
        public int Street { get; set; }
        public string NumberAdress { get; set; }
        public string OperationType { get; set; }

        //Details Info  
       
        public int FloorMaterial { get; set; }
        public int WallMaterial { get; set; }
        public double TotalAreaInfo { get; set; }

         public int ApartmentNumber { get; set; }
         public string ConditionOfApartment { get; set; }
        public string RoomsApartment { get; set; }
        public string RoomType { get; set; }
        public string ReadinessApartment { get; set; }
        public string BathRoomApartment { get; set; }
        public string BalconyApartment { get; set; }
        public string FloorApartment { get; set; }
        public int TotalFloor { get; set; }
        public float LivingAreaApartment { get; set; }
        public float KitchenAreaApartment { get; set; }


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
       
        //Describes object
        public string CaptionLink { get; set; }
        public string NameInfo { get; set; }
        public string InfoDetails { get; set; }
        public string InfoPrivat { get; set; }
        //Money
        public int GrnPrice { get; set; }
        public int DollarPrice { get; set; }
    }
}
