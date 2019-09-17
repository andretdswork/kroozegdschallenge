using System.Collections.Generic;
using Krooze.EntranceTest.WriteHere.Structure.Interfaces;
using Krooze.EntranceTest.WriteHere.Structure.Model;

namespace Krooze.EntranceTest.WriteHere.Structure.Implementations
{
    public class Company2 : IGetCruise
    {
        public int CruiseCompanyCode => 2;
        public List<CruiseDTO> GetCruises(CruiseRequestDTO request)
        {
            return new List<CruiseDTO>()
            {
                new CruiseDTO(){CruiseCode = "C2"},
                new CruiseDTO(){CruiseCode = "C2"}
            };
        }
    }
}
