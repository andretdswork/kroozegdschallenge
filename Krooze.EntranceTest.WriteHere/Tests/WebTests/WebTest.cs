using Krooze.EntranceTest.WriteHere.Structure.Services;
using Newtonsoft.Json.Linq;

namespace Krooze.EntranceTest.WriteHere.Tests.WebTests
{
    public class WebTest
    {
        private MoviesService _moviesService = null;
        public WebTest()
        {
            _moviesService = new MoviesService();
        }
        public JObject GetAllMovies()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the films object
            return _moviesService.GetAllMovies;
        }

        public string GetDirector()
        {
            //TODO: Consume the following API: https://swapi.co/documentation using only .NET standard libraries (do not import the helpers on this page)
            // -Return the name of person that directed the most star wars movies, based on the films object return            
            return _moviesService.GetDirector;
        }        

        
    }
}
