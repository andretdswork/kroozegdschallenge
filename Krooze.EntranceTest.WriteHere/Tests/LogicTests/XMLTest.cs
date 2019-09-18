using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.Extensions.Configuration;

namespace Krooze.EntranceTest.WriteHere.Tests.LogicTests
{
    public class XMLTest
    {
        private XmlCruiseService _xmlCruiseService = null;        
        public XMLTest()
        {
            _xmlCruiseService = new XmlCruiseService();
        }
        
        public CruiseDTO TranslateXML()
        {
            //TODO: Take the Cruises.xml file, on the Resources folder, and translate it to the CruisesDTO object,
            //you can do it in any way, including intermediary objects            
            return _xmlCruiseService.GetCruiseXml();
        }        
    }
}
