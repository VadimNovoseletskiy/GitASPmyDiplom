using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.BusinessLogicLayer.DataTransferObject
{
    public class CommunicationDataTransferLayer
    {
        /// <summary>
        /// Property Id 
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
    }
}
