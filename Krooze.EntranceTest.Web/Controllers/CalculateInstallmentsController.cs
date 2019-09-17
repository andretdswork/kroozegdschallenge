using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{
    
    [ApiController]
    public class CalculateInstallmentsController : ControllerBase
    {
        private CalculateInstallmentsService _calculateInstallmentsService = new CalculateInstallmentsService();

        [Route("api/CalculateInstallments/Installments/{:fullPrice}")]
        [HttpGet]
        public ActionResult<int> Get(decimal fullPrice)
        {
            return _calculateInstallmentsService.GetInstallments(fullPrice);
        }
    }
}