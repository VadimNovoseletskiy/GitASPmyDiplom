using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    /// <summary>
    /// Describes an object "House"
    /// </summary>
    public class House
    {
        /// <summary>
        ///The Foreign Key (one to one communication). Link to the class "Info" 
        /// </summary>
        [Key]
        [ForeignKey("Info")]
        public int Id { get; set; }


        /// <summary>
        /// The property TypeHouse 
        /// </summary>
        ///<value>
        /// Type of House   
        /// </value>
        public TypeOfHouse TypeHouse { get; set; }


        /// <summary>
        /// The property ConditionOfHouse
        /// </summary>
        /// <value>
        /// The condition of the house
        /// </value>
        public ConditionOfHouse ConditionHouse { get; set; }


        /// <summary>
        /// The property PartHouse
        /// </summary>
        /// <value>
        /// Part of House 
        ///  </value>
        public PartOfHouse PartHouse { get; set; }


        /// <summary>
        /// The property RoomsHouse
        /// </summary>
        /// <value>
        /// Number of rooms in the house 
        /// </value>
        public int RoomsHouse { get; set; }


        /// <summary>
        /// The property FloorHouse
        /// </summary>
        /// <value>
        /// Number of floors in the house  
        /// </value>
        public int FloorHouse { get; set; }


        /// <summary>
        /// The property LivingAreaHouse
        /// </summary>
        /// <value>
        /// Living area of house  
        /// </value>
        public float LivingAreaHouse { get; set; }


        /// <summary>
        /// The property KitchenAreaHouse
        /// </summary>
        ///<value>
        /// Living area kitchen in the house  
        /// </value> 
        public float KitchenAreaHouse { get; set; }


        /// <summary>
        /// The property LandAreaHouse
        /// </summary>
        /// <value>
        /// Area of adjacent land 
        /// </value>
        public float LandAreaHouse { get; set; }

        /// <summary>
        /// The property BahtHouseOutBuilding 
        /// </summary>
        ///<value>
        /// The Bathhouse 
        ///</value>

        public bool BahtHouseOutBuilding { get; set; }


        /// <summary>
        /// The property SwimmingOutBuildings
        /// </summary>
        /// <value>
        /// The swimming-pool 
        /// </value>
        public bool SwimmingOutBuildings { get; set; }


        /// <summary>
        /// The property GarageOutBuildings 
        /// </summary>
        /// <value>
        /// The Garage
        /// </value>
        public bool GarageOutBuildings { get; set; }


        /// <summary>
        /// The property WellOutBuildings 
        /// </summary>
        /// <value>
        /// The  Well
        /// </value>
        public bool WellOutBuildings { get; set; }


        /// <summary>
        /// The property SummerKitchenOutBuildings
        /// </summary>
        /// <value>
        /// Summer cuisine   
        /// </value>
        public bool SummerKitchenOutBuildings { get; set; }


        /// <summary>
        /// The property WorkShopOutBuildings
        /// </summary>
        /// <value>
        /// The Workshop
        /// </value>
        public bool WorkShopOutBuildings { get; set; }


        /// <summary>
        /// The property BarnOutBuildings 
        /// </summary>
        /// <value>
        /// The Barn 
        /// </value>
        public bool BarnOutBuildings { get; set; }


        /// <summary>
        /// The property Well1OutBuildings
        /// </summary>
        /// <value>
        /// The Well_1
        /// </value>
        public bool Well1OutBuildings { get; set; }


        /// <summary>
        /// The property GreenHouseOutBuildings
        /// </summary>
        /// <value>
        /// The Greenhouse 
        /// </value>
        public bool GreenHouseOutBuildings { get; set; }


        //Links: 

        /// <summary>
        ///The link to the Parent Class"Info"(one to one communication) 
        /// </summary>
        public Info Info { get; set; }

       // public OutBuilding OutBuilding { get; set; }

    }

    public enum TypeOfHouse
    {
        [Display(Name = "Будинок")]
        House,
        [Display(Name = "Котедж")]
        Cottage,
        [Display(Name = "Літній будинок")]
        SummmerHouse
    }

    public enum ConditionOfHouse
    {
        [Display(Name = "Відмінний")]
        Great,
        [Display(Name = "Хороший")]
        Good,
        [Display(Name = "Задовільній")]
        Satisfactory,
        [Display(Name = "Потрібний ремонт")]
        Repairs,
        [Display(Name = "Оздоблювальні роботи")]
        FinishingWork

    }

    public enum PartOfHouse
    {
        [Display(Name = "1")]
        WholePart,
        [Display(Name = "1/2")]
        Half,
        [Display(Name = "1/3")]
        OneThird,
        [Display(Name = "1/4")]
        OneQuarter,
        [Display(Name = "1/5")]
        OneFifth,
        [Display(Name = "2/3")]
        TwoThirds,
        [Display(Name = "2/5")]
        TwoFifths
    }

}
