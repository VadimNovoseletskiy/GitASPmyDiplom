﻿namespace NLayerApp.BusinessLogicLayer.Models
{
    public class LandViewModel
    {
        public int Id { get; set; }
        public string CaptionLink { get; set; }
        public string Region { get; set; }
        public string Village{ get; set; }
        public string CadastraNumber  { get; set; }
        public string SpecialLand { get; set; }
        public int DollarPrice { get; set; }
        public string OperationType { get; set; }
        public double TotalAreaInfo { get; set; }

        //add id for Image
        public int? IdPicture { get; set; }

    }
}