using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.DataTransferObject
{
    /// <summary>
    /// Describes an object"Land"
    /// </summary>
    public class LandViewModel
    {
        
        public int Id { get; set; }

        public string SpecialLand { get; set; }

        public float LandArea { get; set; }
    }
}
