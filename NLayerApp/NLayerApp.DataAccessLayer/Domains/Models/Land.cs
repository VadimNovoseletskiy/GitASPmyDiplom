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
    /// Describes an object"Land"
    /// </summary>
    public class Land
    {
        /// <summary>
        /// The Foreign Key. Link(one to one communication ) to the class "Info" 
        /// </summary>
        [Key]
        [ForeignKey("Info")]
        public int Id { get; set; }


        /// <summary>
        /// The property SpesialLand
        /// </summary>
        ///<value>
        /// Describe special Land
        /// </value>
        public string SpecialLand { get; set; }

        /// <summary>
        /// The property Cadastral Number  
        /// </summary>
        /// <value>
        /// Describe Cadastral Number
        /// </value>
        public string CadastralNumber { get; set; }





        //Links

        /// <summary>
        /// The link to the Parent Class "Info" (one to one communication ) 
        /// </summary>
        public Info Info { get; set; }


    }

    public enum SpecialTypeLand
    {   [Display(Name = "Індивідуальне")]
        Individual,
        [Display(Name = "Комерційне")]
        Commercial,
        [Display(Name = "Сільськогосподарське")]
        Agricultural
    }
}























