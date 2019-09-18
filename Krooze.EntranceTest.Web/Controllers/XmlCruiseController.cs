using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

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