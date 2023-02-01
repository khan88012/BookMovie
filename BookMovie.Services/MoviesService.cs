using BookMovie.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookMovie.Services
{
    public class MoviesService : IMoviesService
    {
        //public List<Movie> Movies = new List<Movie>() { 
        //new Movie(){Id="1", Name="pathan", Location="Hyderabad"},
        //new Movie(){Id="2",Name="war",Location="Delhi"}
        //};
       
       
        public MoviesList GetMovies()
        {
            string fileName = "C:\\Asif\\Asif Projects\\BookMovie.Data\\Movies.json";
            string result = File.ReadAllText(fileName);
            var Movies = JsonConvert.DeserializeObject<MoviesList>(result);
            return Movies;
        }
    }
}
