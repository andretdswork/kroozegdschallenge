using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Structure.Services;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class SimpleLogicTest
    {
        private CruiseService _cruiseService = null;
        private CalculateInstallmentsService _calculateInstallmentsService = null;
        public SimpleLogicTest()
        {
            _cruiseService = new CruiseService();
            _calculateInstallmentsService = new CalculateInstallmentsService();
        }

        public decimal? GetOtherTaxes(CruiseDTO cruise)
        {
            //TODO: Based on the CruisesDTO object, gets if there is some other tax that not the port charge
            return _cruiseService.GetOtherTaxes(cruise);
        }

        public bool? IsThereDiscount(CruiseDTO cruise)
        {
            //TODO: Based on the CruisesDTO object, check if the second passenger has some kind of discount, based on the first passenger price
            //Assume there are always 2 passengers on the list
            return cruise.IsThereDiscount;
        }

        public int? GetInstallments(decimal fullPrice)
        {
            //TODO: Based on the full price, find the max number of installments
            // -The absolute max number is 12
            // -The minimum value of the installment is 200
            return _calculateInstallmentsService.GetInstallments(fullPrice);
        }        
    }
}
