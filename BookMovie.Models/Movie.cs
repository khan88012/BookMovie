using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMovie.Models

{

    public class MoviesList
    {
        [JsonProperty("Movies")]
        public List<Movie> Movies { get; set; }
    }
    public class Movie
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Location")]
        public string Location { get; set; }
        [JsonProperty("Theatre")]
        public string Theatre { get; set; }
    }
}
