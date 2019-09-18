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
        public CruiseService()
        {
            _cruiseDTO = new CruiseDTO();
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

        public decimal GetOtherTaxes(decimal cabinValue, decimal portCharge, decimal totalValue)
        {            
            return totalValue - cabinValue - portCharge;
        }

        public bool IsThereDiscount(decimal firstPassenger, decimal secondPassenger)
        {
            _cruiseDTO = new CruiseDTO()
            {
                PassengerCruise = new List<PassengerCruiseDTO>()
                {
                    new PassengerCruiseDTO()
                        {PassengerCode = "1", Cruise = new CruiseDTO() {CabinValue = firstPassenger}},
                    new PassengerCruiseDTO()
                        {PassengerCode = "2", Cruise = new CruiseDTO() {CabinValue = secondPassenger}},
                }
            };

            return _cruiseDTO.IsThereDiscount();
        }

        #endregion
    }
}
