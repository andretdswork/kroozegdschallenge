using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Krooze.EntranceTest.WriteHere.Structure.Model
{    
    public class PassengerCruiseDTO
    {
        public CruiseDTO Cruise { get; set; }
        
        public string PassengerCode { get; set; }
    }
}
