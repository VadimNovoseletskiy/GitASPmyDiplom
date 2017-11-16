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
    /// Describe an object"Commercial property"  
    /// </summary>
    public class Commercial
    {
        /// <summary>
        ///The  Foreign Key (one to one communication).Link to the class"Info" 
        /// </summary>
        [Key]
        [ForeignKey("Info")]
        public int Id { get; set; }


        /// <summary>
        /// Property TypeCommersial
        /// </summary>
        /// <value>
        /// Commercial type 
        /// </value>
        public string TypeCommercial { get; set; }


        /// <summary>
        /// Property StateCommersial
        /// </summary>
        /// <value>
        /// State  
        /// </value>
        public string StateCommercial { get; set; }


        /// <summary>
        /// Property FloorCommersial
        /// </summary>
        /// <value>
        /// Floor where is the commercial real estate
        /// </value>
        public string FloorCommercial { get; set; }


        /// <summary>
        /// Property TotalFloorCommersial
        /// </summary>
        /// <value>
        /// Number of floors
        /// </value>
        public int TotalFloorCommercial { get; set; }


        /// <summary>
        /// Property EffectiveAreaCommmersial
        /// </summary>
        /// <value>
        /// Effective area  
        /// </value>
        public float EffectiveAreaCommercial { get; set; }


        /// <summary>
        /// Property LandAreaCommersial
        /// </summary>
        /// <value>
        /// Area of adjacent land 
        ///  </value>
        public float LandAreaCommercial { get; set; }


        /// <summary>
        /// Property OficeNumber
        /// </summary>
        /// <value>
        /// The Number of office
        /// </value>
        public int OficeNumber { get; set; }


        //Links:

        /// <summary>
        /// The  a link to the Parent class "Info"(one to one communication) 
        /// </summary>
        public Info Info { get; set; }
    }

    public enum SpecialTypeCommercial
    {
        [Display(Name = "Офісно-Адміністративне")]
        OfficeAdministrative,
        [Display(Name = "Виробниче")]
        Production,
        [Display(Name = "Складське")]
        WareHouse,
        [Display(Name = "Торгове")]
        Pomegranate,
        [Display(Name = "Розважальне")]
        Entertaining,
        [Display(Name = "Гараж")]
        Garage,
        [Display(Name = "Вільне призначення")]
        FreeAssignment

    }

    public enum ConditionOfCommercial
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

    public enum SpecialFloorCommercial
    {
        [Display(Name = "Підвал")]
        Basement,
        [Display(Name = "Цокольний поверх")]
        GroundFloor,
        [Display(Name = "1")]
        One,
        [Display(Name = "2")]
        Two,
        [Display(Name = "3")]
        Three,
        [Display(Name = "4")]
        Four,
        [Display(Name = "5")]
        Five,
        [Display(Name = "6")]
        Six,
        [Display(Name = "7")]
        Seven,
        [Display(Name = "8")]
        Eight,
        [Display(Name = "9")]
        Nine,
        [Display(Name = "10")]
        Ten,
        [Display(Name = "11")]
        Eleven,
        [Display(Name = "12")]
        Twelve,
        [Display(Name = "13")]
        Thirteen,
        [Display(Name = "14")]
        Fourteeen,
        [Display(Name = "15")]
        Fifteen
    }
}
