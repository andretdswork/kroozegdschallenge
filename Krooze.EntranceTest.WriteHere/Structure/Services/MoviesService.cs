using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Krooze.EntranceTest.WriteHere.Structure.Services
{
    public class MoviesService
    {
        const string URL_MOVIES = "https://swapi.co/api/films/";
        private string responseResult = string.Empty;
        private JObject Movies = null;

        public MoviesService()
        {
            if (Movies == null)
                SetMoviesResponse();
        }
        private void SetMoviesResponse()
        {
            using (var request = new HttpClient())
            {
                Task<HttpResponseMessage> response = request.GetAsync(URL_MOVIES);
                if (response.Result.IsSuccessStatusCode)
                {
                    responseResult = response.Result.Content.ReadAsStringAsync().Result;
                }
                Movies = JObject.Parse(responseResult);
            }
        }

        public JObject GetAllMovies
        {
            get {
                return Movies;
            }            
        }

        public string GetDirector
        {
            get {
                return Movies.SelectToken("results[3].director").ToString();
            }
        }
    }
}
