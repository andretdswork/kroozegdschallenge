using System;
using System.Collections.Generic;
using System.Text;

namespace Krooze.EntranceTest.WriteHere.Structure.Services
{
    public class CalculateInstallmentsService
    {
        private const int MINIUM_VALUE_INSTALLMENTS = 200;
        private const int MAX_NUMBER_OF_INSTALLMENTS = 12;        
        
        private int CalculateInstallment(decimal fullPrice)
        {
            return (GetTotalInstallments(fullPrice) > MAX_NUMBER_OF_INSTALLMENTS ? MAX_NUMBER_OF_INSTALLMENTS : GetTotalInstallments(fullPrice));
        }

        private int GetTotalInstallments(decimal fullPrice)
        {
            return (int)(fullPrice / MINIUM_VALUE_INSTALLMENTS);
        }

        public int GetInstallments(decimal fullPrice) {
            return fullPrice < MINIUM_VALUE_INSTALLMENTS ? 1 : CalculateInstallment(fullPrice);            
        }
            
    }
}
