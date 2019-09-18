using Krooze.EntranceTest.WriteHere.Structure.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Krooze.EntranceTest.Web.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MoviesService _moviesService = new MoviesService();

        [Route("api/movies/allMovies")]
        [HttpGet]
        public ActionResult<JObject> Get()
        {
            return _moviesService.GetAllMovies;
        }

        [Route("api/movies/director")]
        public ActionResult<string> GetDirector()
        {
            return _moviesService.GetDirector;
        }
    }
}