using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class XmlCruiseController : ControllerBase
    {
        private XmlCruiseService _xmlCruiseService = null;       

        public XmlCruiseController()
        {            
            _xmlCruiseService = new XmlCruiseService();
        }

        [Route("CruiseXml")]
        [HttpGet]
        public ActionResult<CruiseDTO> Get()
        {            
            return _xmlCruiseService.GetCruiseXml();
        }
    }
}