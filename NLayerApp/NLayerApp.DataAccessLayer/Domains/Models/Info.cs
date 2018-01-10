using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.DataAccessLayer.Domains.Models
{
    public class Info
    {
        /// <summary>
        /// The property Id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The property NameCaptionLink
        /// </summary>
        /// <value>
        /// short caption link 
        /// </value>
        public string NameCaptionLink { get; set; }

        /// <summary>
        /// The property DetailsInfo
        /// </summary>
        /// <value>
        /// Detailed description of the property  
        /// </value>
        public string DetailsInfo { get; set; }

        /// <summary>
        /// The property Type 
        /// </summary>
        /// <value>
        /// Object type 
        /// </value>
        public PropertyType Type { get; set; }
        
        /// <summary>
        /// The property "Operation Type"
        /// </summary>
        /// <value>
        /// Enum type of operation(sale, lease)
        /// </value>
        public string OperationType { get; set; }

        /// <summary>
        /// The property "Address Number" 
        /// Describes the number  of the house.
        /// </summary>
        public string AddressNumber { get; set; }

        /// <summary>
        /// The property TotalAreaInfo 
        /// </summary>
        /// <value>
        /// Common object
        /// </value>
        public double TotalAreaInfo { get; set; }


        /// <summary>
        /// The property GrnPrice
        /// </summary>
        /// <value>
        /// The price of the object in UAN
        /// </value>
        public int GrnPrice { get; set; }


        /// <summary>
        /// The property DollarPrice
        /// </summary>
        /// <value>
        /// The price of the object in dollars 
        /// </value>
        public int DollarPrice { get; set; }

        
        //Links:

        /// <summary>
        /// Foreign Key
        /// The link to the class "Village"(one to many communication) 
        /// </summary>
        public int? VillageId { get; set; }
        public Village Village { get; set; }
       
        /// <summary>
        /// The Foreign Key.
        /// The link to the class "Region"(one to many communication)
        /// </summary> 
        public int? RegionId { get; set; }
        public Region Region { get; set; }

        /// <summary>
        /// The Foreign Key.
        /// The link to the class "Street"(one to many communication)
        /// </summary> 
        public int? StreetId { get; set; }
        public Street Street { get; set; }

        // <summary>
        /// The Foreign Key
        /// The link to the class "Communication" (one to many communication).
        /// </summary>
        public int? CommunicationId { get; set; }
        public Communication Communication { get; set; }

        /// <summary>
        /// The Foreign Key
        /// The link to the class "AdditionalEquipment" (one to many communication).
        /// </summary>
        public int? AdditionalEquipmentId { get; set; }
        public AdditionalEquipment AdditionalEquipment { get; set; }

        /// <summary>
        /// The Foreign Key
        /// The link to the class "WallMaterial" (one to many communication).
        /// </summary>
        public int? WallMaterialId { get; set; }
        public WallMaterial WallMaterial { get; set; }

        /// <summary>
        /// The Foreign Key
        /// The link to the class "FloorMaterial" (one to many communication).
        /// </summary>
        public int? FloorMaterialId { get; set; }
        public FloorMaterial FloorMaterial { get; set; }

        /// <summary>
        /// The link to the Child class"Apartment"(one to one communication) 
        /// </summary>
        public Apartment Apartment { get; set; }


        /// <summary>
        /// The link to the Child class"House"(one to one communication) 
        /// </summary>
        public House House { get; set; }


        /// <summary>
        /// The link to the Child class "Commercial" (one to one communication)
        /// </summary>
        public Commercial Commercial { get; set; }

        /// <summary>
        /// The link to the Child class "Land" (one to one communication)
        /// </summary>
        public Land Land { get; set; }

        //public Picture Picture { get; set; }


        /// <summary>
        /// The navigation property
        /// The link to the class "Picture"(one to many communication)
        /// </summary>
        public ICollection<Picture> Pictures { get; set; }

        public Info()
        {
            Pictures = new List<Picture>();
        }


    }

    public enum PropertyType
    {
        [Display(Name = "Будинок")]
        House,
        [Display(Name="Квартира")]
        Apartment,
        [Display (Name = "Комерційна нерухомість")]
        Commercial, 
        [Display(Name = "Земля")]
        Land
    }

    public enum TypeOfOperation
    {
        //аренда, продажа
        [Display(Name = "Оренда")]
        Lease,
        [Display(Name = "Продаж")]
        Sale
    }
}
