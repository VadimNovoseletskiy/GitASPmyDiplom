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

        public string SpecialLand { get; set; }

        public int CostTo { get; set; }
    }
}
