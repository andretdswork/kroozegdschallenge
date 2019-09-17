using Krooze.EntranceTest.WriteHere.Structure.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Krooze.EntranceTest.WriteHere.Structure.Services
{
    public class CruiseService
    {
        private CruiseDTO _cruiseDTO;
        public CruiseService() { }
        public CruiseService(CruiseDTO cruiseDTO)
        {
            _cruiseDTO = cruiseDTO;
        }

        #region Methods        

        public List<CruiseDTO> GetCruises(int cruiseRequestDTO)
        {
            if (cruiseRequestDTO > 3)
                throw new Exception("Não pode ser maior do que 3");

            for (int i = 1; i <= cruiseRequestDTO; i++)
            {
                ListCruiseDTO.Add(new CruiseDTO()
                {
                    CruiseCode = $"C{cruiseRequestDTO}"
                });
            }
            return ListCruiseDTO;
        }
        

        private List<CruiseDTO> ListCruiseDTO = new List<CruiseDTO>();

        public decimal GetOtherTaxes(CruiseDTO cruiseDTO)
        {            
            return cruiseDTO.TotalValue - cruiseDTO.CabinValue - cruiseDTO.PortCharge;
        }

        

        #endregion
    }
}
