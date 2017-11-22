using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class LandDetailsViewModel
    {
        public int Id { get; set; }
        public string CaptionLink { get; set; }
        public string NameInfo { get; set; }
        public string Region { get; set; }
        public string Village { get; set; }
        public double TotalAreaInfo { get; set; }
        public int DollarPrice { get; set; }
        public string DetailsInfo { get; set; }

    }
}
