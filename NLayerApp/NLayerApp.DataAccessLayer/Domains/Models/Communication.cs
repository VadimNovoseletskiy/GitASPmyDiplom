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
    /// Describes communication
    /// </summary>
    public class Communication
    {
        /// <summary>
        /// The Foreign Key (one to one communication). Link to the Parent Class "Land,Commercial,House "
        /// </summary>
        
        public int Id { get; set; }


        /// <summary>
        /// The property Gas
        /// </summary>
        /// <value>
        /// Describe communication:gas
        /// </value>
        public bool GasCommunications { get; set; }
        
        /// <summary>
        /// The property RailWay
        /// </summary>
        /// <value>
        /// Describe communication:rail way
        /// </value>
        public bool RailWay { get; set; }

        /// <summary>
        /// The property Electricity
        /// </summary>
        ///<value>
        /// Describe communication:electricity
        /// </value>
        public bool ElectricityCommunications { get; set; }


        /// <summary>
        /// The property Central sewerage
        /// </summary>
        /// <value>
        /// Describe communication:central Sewerage
        /// </value>
        public bool CentralSewerageCommunications { get; set; }


        /// <summary>
        /// The property CentralWaterCommmunications
        /// </summary>
        /// <value>
        /// Describe communication: central water supply
        /// </value>
        public bool CentralWaterCommunications { get; set; }


        /// <summary>
        /// The property CentralHeatingCommunications
        /// </summary>
        /// <value>
        /// Describe communication:central Heating 
        /// </value>
        public bool CentralHeatingCommunications { get; set; }


        /// <summary>
        /// The property AutonomousSewerageCommunications 
        /// </summary>
        /// <value>
        /// Describe communication:autonomous sewerage
        /// </value>
        public bool AutonomousSewerageCommunications { get; set; }


        /// <summary>
        /// The property AutonomusWaterCommmunications 
        /// </summary>
        /// <value>
        /// Describe communication : autonomous water supply
        /// </value>
        public bool AutonomousWaterCommunications { get; set; }


        /// <summary>
        /// The property AutonomusHeatingCommunications
        /// </summary>
        /// <value>
        /// Describe communication : autonomous heating
        /// </value>
        public bool AutonomusHeatingCommunications { get; set; }

        //Links:

        public ICollection<Info> Infos { get; set; }

        public Communication()
        {
            Infos = new List<Info>();
        }

       // public Info Info { get; set; }




    }
}
