using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace Krooze.EntranceTest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculateInstallmentsController : ControllerBase
    {
        private CalculateInstallmentsService _calculateInstallmentsService = new CalculateInstallmentsService();
        
        [Route("Installments/{fullPrice}")]
        [HttpGet]
        public ActionResult<int> Get(decimal fullPrice)
        {
            return _calculateInstallmentsService.GetInstallments(fullPrice);
        }        
    }
}