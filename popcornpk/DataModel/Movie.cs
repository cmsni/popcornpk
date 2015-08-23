using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popcornpk.DataModel
{
      public class Movie
     {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string secondry_images { get; set; }
        public string actor { get; set; }
        public string actoress { get; set; }
        public string director { get; set; }
        public string music_director { get; set; }
        public string release_date { get; set; }
        public string tags { get; set; }
        public string age_restriction { get; set; }
        public string box_office { get; set; }
        public string official_site { get; set; }
        public string duration { get; set; }
        public string writers { get; set; }
        public int imdb { get; set; }
        public string status { get; set; }
        public string language { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
        public string movie_category_id { get; set; }
        public string slug { get; set; }
        public string movie_show_time_id { get; set; }
        public string theatre_movie_screen_id { get; set; }
        public string videous { get; set; }
        public string videos { get; set; }
        public string comming_soon { get; set; }
        public string avg { get; set; }
     }

     public class MovieList
     {
        public List<Movie> movie_list { get; set; }
     }
  
}
