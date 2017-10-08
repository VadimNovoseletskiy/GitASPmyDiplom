using NLayerApp.DataAccessLayer.Domains.Models;

namespace NLayerApp.BusinessLogicLayer.Models
{
    /// <summary>
    /// Describes an object"Land"
    /// </summary>
    public class LandSearchParameters
    {

        public string Village{ get; set; }

        public string Region { get; set;}

        public SpecialTypeLand SpecialLand { get; set; }

        public float LandArea { get; set; }

        public int CostFrom { get; set; }

        public int CostTo { get; set; }
    }
}
