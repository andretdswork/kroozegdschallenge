using System.Collections.Generic;
using Krooze.EntranceTest.WriteHere.Structure.Interfaces;
using Krooze.EntranceTest.WriteHere.Structure.Model;

namespace Krooze.EntranceTest.WriteHere.Structure.Implementations
{
    public class Company3 :IGetCruise
    {
        public int CruiseCompanyCode => 3;
        public List<CruiseDTO> GetCruises(CruiseRequestDTO request)
        {
            return new List<CruiseDTO>()
            {
                new CruiseDTO(){ CruiseCode = "C3"},
                new CruiseDTO(){ CruiseCode = "C3"},
                new CruiseDTO(){ CruiseCode = "C3"},
            };
        }
    }
}
