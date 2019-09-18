using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Krooze.EntranceTest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CruiseController : ControllerBase
    {
        private CruiseService _cruiseService = new CruiseService();        

        [Route("{cruiseRequestDTO}")]
        [HttpGet]
        public ActionResult<List<CruiseDTO>> Get(int cruiseRequestDTO)        
        {
            return _cruiseService.GetCruises(cruiseRequestDTO);
        }

        [Route("IsThereDiscount/{firstPassenger}/{secondPassenger}")]
        [HttpGet]
        public ActionResult<bool> Get(decimal firstPassenger, decimal secondPassenger)
        {
            return _cruiseService.IsThereDiscount(firstPassenger, secondPassenger);
        }

        [Route("OtherTaxes/{cabinValue}/{portCharge}/{totalValue}")]
        [HttpGet]
        public ActionResult<decimal> Get(decimal cabinValue, decimal portCharge, decimal totalValue)
        {
            return _cruiseService.GetOtherTaxes(cabinValue, portCharge, totalValue);
        }
    }
}