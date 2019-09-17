using System.Collections.Generic;
using Krooze.EntranceTest.WriteHere.Structure.Interfaces;
using Krooze.EntranceTest.WriteHere.Structure.Model;

namespace Krooze.EntranceTest.WriteHere.Structure.Implementations
{
    public class Company1 : IGetCruise
    {
        public int CruiseCompanyCode => 1;
        public List<CruiseDTO> GetCruises(CruiseRequestDTO request)
        {
            return new List<CruiseDTO>()
            {
                new CruiseDTO() {CruiseCode = "C1"}
            };
        }
    }
}
