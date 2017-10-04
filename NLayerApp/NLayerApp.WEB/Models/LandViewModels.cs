using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NLayerApp.WEB.Models
{
    public class LandViewModels
    {
        //ссылка-краткий заголовок
        public string NameInfo { get; set; }
        public string VillageRegion { get; set; }
        public float TotalAreaInfo { get; set; }
        public int GrnPrice { get; set; }
        public int DollarPrice { get; set; }
    }
}