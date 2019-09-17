using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculateInstallmentsController : ControllerBase
    {
        private CalculateInstallmentsService _calculateInstallmentsService = new CalculateInstallmentsService();
        
        [HttpGet("{fullPrice}")]        
        public ActionResult<int> Get(decimal fullPrice)
        {
            return _calculateInstallmentsService.GetInstallments(fullPrice);
        }
    }
}