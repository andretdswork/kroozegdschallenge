using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace Krooze.EntranceTest.WriteHere.Structure.Model
{
    /// <summary>
    /// Cruise Transfer Object
    /// </summary>    
    public class CruiseDTO
    {        
        public string CruiseCode { get; set; }        
        
        public decimal TotalValue { get; set; }        
        
        public decimal CabinValue { get; set; }
        
        [XmlElement("PortChargesAmt")]
        public decimal PortCharge { get; set; }
        
        public string ShipName { get; set; }
        
        public List<PassengerCruiseDTO> PassengerCruise { get; set; }

        public bool IsThereDiscount()
        {
            return this.LastCabinValue() < this.FirstCabinValue();
        }        
        private decimal FirstCabinValue()
        {            
            return this.PassengerCruise.First().Cruise.CabinValue;
        }

        private decimal LastCabinValue()
        {            
            return this.PassengerCruise.Last().Cruise.CabinValue;            
        }

        
    }
}
