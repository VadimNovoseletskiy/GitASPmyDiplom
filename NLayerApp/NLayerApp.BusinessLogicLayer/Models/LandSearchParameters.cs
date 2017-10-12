using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    /// <summary>
    /// Describes an object"Land"
    /// </summary>
    public class LandSearchParameters
    {

        public int Region { get; set; }

        public int Village{ get; set; }

        public SpecialTypeLand SpecialLand { get; set; }

        //public float LandArea { get; set; }

        public int CostFrom { get; set; }

        public int CostTo { get; set; }
    }
}
