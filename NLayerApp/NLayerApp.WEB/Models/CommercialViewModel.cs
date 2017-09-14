using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.WEB.Models
{
    /// <summary>
    /// Describe an object"Commercial property"  
    /// </summary>
    public class CommercialViewModel
    {
        
        public int Id { get; set; }

        public string TypeCommercial { get; set; }

        public string StateCommercial { get; set; }

        public int FloorCommercial { get; set; }

        public int TotalFloorCommercial { get; set; }

        public float EffectiveAreaCommercial { get; set; }

        public float LandAreaCommercial { get; set; }
    }
}
