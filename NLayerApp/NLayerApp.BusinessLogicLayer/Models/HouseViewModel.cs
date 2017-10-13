using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    public class HouseViewModel
    {
        public int Id { get; set; }
        public string CaptionLint { get; set; }
        public string Village{ get; set; }
        public string Region { get; set; }
        public SpecialTypeHouse TypeHouse { get; set; }
        public int Floor { get; set; }
        public float TotalArea { get; set; }

    }
}
