namespace NLayerApp.BusinessLogicLayer.Models
{
    /// <summary>
    /// Describes an object"Land"
    /// </summary>
    public class LandSearchParameters
    {

        public string SpecialType { get; set; }

        public string VillageRegion { get; set; }

        public string SpecialLand { get; set; }

        public float LandArea { get; set; }

        public int CostFrom { get; set; }

        public int CostTo { get; set; }
    }
}
