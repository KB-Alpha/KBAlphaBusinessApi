using KBAlphaBusinessApi.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Services
{
    public class APIConnector
    {
        #region Finaince connectors
        //Alpha vantage api connector
        public static HttpResponseMessage Start_Alpha_Vantage_Connection(string endpoint)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("apikey", "demo");

                    var data = client.GetAsync(endpoint).GetAwaiter().GetResult();

                    return data;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Commodaties api connector
        public static HttpResponseMessage Start_Commadaties_Connection(string endpoint)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var data = client.GetAsync(endpoint).GetAwaiter().GetResult();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Polyogon api connector
        public static HttpResponseMessage Start_Polygon_API_Connection(string endpoint)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.PolygonApiKey);

                    client.BaseAddress = new Uri(endpoint);

                    var response = client.GetAsync(endpoint).GetAwaiter().GetResult();

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Yahoo api connector 
        public static HttpResponseMessage Start_Yahoo_API_Conection(string endpoint)
        {

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("x-api-key", Constants.YahooApiKey);
                    client.DefaultRequestHeaders.Add("x-api-key", Constants.YahooApiKey);


                    client.BaseAddress = new Uri(endpoint);

                    var response = client.GetAsync(endpoint).GetAwaiter().GetResult();

                    return response;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Commo Prices api connector
        public static HttpResponseMessage Start_Commo_Prices_Connection(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constants.Commo_Prices_API_Key);

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    var data = client.GetAsync(url).GetAwaiter().GetResult();

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Database
        public static void Start_MongoDB_Connection()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region CRM
        //Get connection
        public static HttpResponseMessage Start_Get_HubSpot_Connection(string endpoint)
        {
            try
            {

                string HubSpot_API_Path = "https://api.hubapi.com/{0}?hapikey={1}";

                
                HubSpot_API_Path = string.Format(HubSpot_API_Path, endpoint, Constants.HubSpot_API_KEY);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.BaseAddress = new Uri(HubSpot_API_Path);

                    HttpResponseMessage response = client.GetAsync(HubSpot_API_Path).GetAwaiter().GetResult();

                    return response;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async static Task<string> Start_Post_Hubspot_Connection(string endpoint, HttpContent content)
        {
            try
            {
                string HubSpot_API_Path = "https://api.hubapi.com/{0}?hapikey={1}";

                HubSpot_API_Path = string.Format(HubSpot_API_Path, endpoint, Constants.HubSpot_API_KEY);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                     var post =await client.PostAsync(HubSpot_API_Path, content);

                    return post.Content.ReadAsStringAsync().Result;
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
