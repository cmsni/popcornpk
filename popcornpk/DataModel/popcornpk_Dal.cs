using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Windows.UI.Popups;
using popcornpk.Helpers;

namespace popcornpk.DataModel
{
    public class popcornpk_Dal
    {

   

        public async Task<List<City>> GetCityListAsync()
        {

            var tcs = new TaskCompletionSource<List<City>>();
            string jsonresult = await WCFRESTServiceCall("GET", "cinema_city");

            var list = await Task.Run(() => JsonConvert.DeserializeObject<List<City>>(jsonresult)); 
            tcs.SetResult(list.ToList());
            // for testing to show json being returned
            var dialog = new MessageDialog(jsonresult);
            await dialog.ShowAsync();

            return await tcs.Task;
        }



        public async Task<MovieList> GetAllMovies()
        {
            string jsonresult = await WCFRESTServiceCall("GET", "list_of_movie");
            var jarray = JsonConvert.DeserializeObject<MovieList>(jsonresult);


            return jarray;
        }
        public async Task<MovieDetail> GetMovieDetails(int movieId)
        {
            string jsonresult = await WCFRESTServiceCall("GET", "movie_details");
            MovieDetail details = jsonresult.Deserialize<MovieDetail>();
           
            
            return details;
        }

        public async Task<MovieDetail> searchMovies(string movietitle)
        {
            MovieDetail _myMovie = await GetMovieDetails(1);
            var list = _myMovie;
            return list;
        }

        /// <summary>
        /// Utility function to get/post WCFRESTService
        /// </summary>
        /// <param name="methodRequestType">RequestType:GET/POST</param>
        /// <param name="methodName">WCFREST Method Name To GET/POST</param>
        /// <param name="bodyParam">Parameter of POST Method (Need serialize to JSON before passed in)</param>
        /// <returns>Created by David</returns>
        private async Task<string> WCFRESTServiceCall(string methodRequestType, string methodName, string bodyParam = "")


        {
            try {
                string ServiceURI = "http://popcorn.pk/app/webroot/launchwebservice/index.php/webservice/" + methodName;
                HttpClient httpClient = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage(methodRequestType == "GET" ? HttpMethod.Get : HttpMethod.Post, ServiceURI);
                if (!string.IsNullOrEmpty(bodyParam))
                {
                    request.Content = new StringContent(bodyParam, Encoding.UTF8, "application/json");
                }
                HttpResponseMessage response = await httpClient.SendAsync(request);
                string jsongString = await response.Content.ReadAsStringAsync();
                return jsongString;

            }
            catch(Exception ex)
            {

                return "";            }
        }
    }
}
