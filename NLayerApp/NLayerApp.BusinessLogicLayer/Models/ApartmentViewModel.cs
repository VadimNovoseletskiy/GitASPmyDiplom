using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.Models
{
     public  class ApartmentViewModel
    {
         public int Id { get; set; }
         public string CaptionLink { get; set; }
         public string Village{ get; set; }
         public string Region { get; set; }
         public int Floor { get; set; }
         public int NumberOfRooms { get; set; }
         public float TotalAreaInfo { get; set; }
         public int DollarPrice { get; set; }
         public int GrnPrice { get; set; }

    }
}
