﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popcornpk.DataModel
{
    public class MovieDetails
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
        public int avg { get; set; }
        public string movie_details_url { get; set; }
    }

    public class FetchTiming
    {
        public string id { get; set; }
        public string theater_name { get; set; }
        public string address { get; set; }
        public List<string> show_times { get; set; }
        public string screen_id { get; set; }
        public string title { get; set; }
    }

    public class MovieDetail
    {
        public MovieDetails movie_details { get; set; }
        public List<FetchTiming> fetch_timing { get; set; }
    }


}
