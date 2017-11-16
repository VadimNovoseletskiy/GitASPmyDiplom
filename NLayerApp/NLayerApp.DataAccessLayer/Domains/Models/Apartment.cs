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
    /// Describes an object "Apartment"
    /// </summary>
    public class Apartment
    {
        /// <summary>
        ///The Foreign Key (one to one communication). Link to the class "Info" 
        /// </summary>
        [Key]
        [ForeignKey("Info")]
        public int Id { get; set; }

        /// <summary>
        /// Property ConditionOfApartment
        /// </summary>
        /// <value>
        /// Describes the condition of the apartment
        /// </value>
        public string ConditionOfApartment { get; set; }


        /// <summary>
        /// Property  ApartmentNumber
        /// </summary>
        /// <value>
        ///  Describes the Apartment number.
        /// </value>
        public int ApartmentNumber { get; set; }


        /// <summary>
        /// Property Number of floors in the house
        /// </summary>
        /// <value>
        /// Describes number of floors in the house
        /// </value>
        public int TotalFloorApartment { get; set; }


        /// <summary>
        /// Property FloorApartment
        /// </summary>
        /// <value>
        /// Describes floor, where is the  apartment  
        /// </value>
        public string FloorApartment { get; set; }


        /// <summary>
        /// Property LivingAreaApartment
        /// </summary>
        /// <value>
        /// Describes living space   
        /// </value>
        public float LivingAreaApartment { get; set; }


        /// <summary>
        /// Property KitchenAreaApartment
        /// </summary>
        /// <value>
        /// Describes kitchen area
        /// </value>
        public float KitchenAreaApartment { get; set; }


        /// <summary>
        /// Property RoomsApartment
        /// </summary>
        /// <value>
        /// Describes the number of rooms in the apartment 
        /// </value>
        public string RoomsApartment { get; set; }

        /// <summary>
        /// Property type room apartment
        /// </summary>
        /// <value>
        /// Describes the type of room in the Apartment.
        /// </value>
        public string TypeRoom { get; set; }

        /// <summary>
        /// Property BathRoomApartment
        /// </summary>
        /// <value>
        /// Describes the bathroom
        /// </value>
        public string BathRoomApartment { get; set; }


        /// <summary>
        /// Property BalconyApartment
        /// </summary>
        /// <value>
        ///The presence of a balcony  
        /// </value>
        public string BalconyApartment { get; set; }


        /// <summary>
        /// Property ReadinessApartment
        /// </summary>
        /// <value>
        /// Readiness for setting 
        ///  </value>
        public string ReadinessApartment { get; set; }


        //Links: 

        /// <summary>
        ///The link to the Parent Class"Info"(one to one communication) 
        /// </summary>
        public Info Info { get; set; }
        
    }
    /// <summary>
    /// Enu.Describes type of room
    /// </summary>
    public enum SpecialTypeRoom
    {   [Display (Name = "Роздільні ")]
        SeparateRooms,
        [Display(Name = "Суміжні")]
        AdjoiningRooms,
        [Display(Name = "Комбіновані")]
        CombinedRooms
    }

    public enum ConditionOfApartment
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

    public enum SpecialFloorApartment
    {
        [Display (Name = "Підвал")]
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

    public enum SpecialReadiness
    {
        [Display(Name = "В експлуатації")]
        InOperation,
        [Display(Name = "Новобудова")]
        NewBuilding,
        [Display(Name = "Будується")]
        Build,
        [Display(Name = "Вільна")]
        Free
    }

    public enum SpecialBathRoomApartment
    {
        [Display (Name = "Роздільний")]
        Separated,
        [Display(Name = "Спільній")]
        Сommon,
        [Display(Name = "2 і більше")]
        TwoOrMore,
        [Display(Name = "Відсутній")]
        Absent
    }

    public enum SpecialBalconyApartment
    {
        [Display (Name = "Відсутній")]
        Absent,
        [Display(Name = "1")]
        One,
        [Display(Name = "2")]
        Two,
        [Display(Name = "3")]
        Three
        
    }

    public enum SpecialRoomsApartment
    {
        [Display(Name = "Однокімнатна")]
        One=1,
        [Display(Name = "Двокімнатна")]
        Two =2,
        [Display(Name = "Трикімнатна")]
        Three =3,
        [Display(Name = "Чотирикімнатна")]
        Four =4,
        [Display(Name = "5 і більше")]
        FiveOrMore =5
    }

}
