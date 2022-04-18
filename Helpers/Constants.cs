using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Helpers
{
    public class Constants
    {
        #region Finaince Constants
        //Yahoo api key
        public const string YahooApiKey = "XtEYTQpjGA3rq7OFKwznP5IExLOFpqta5JlwVQx4";

        //Yahoo base url
        public const string BaseUrl = "https://yfapi.net/";

        //Interactive brockers api key
        public const string InteractiveBrockersApiKey = "";

        //Interactive brokers
        public const string InteractiveBrokersBaseUrl = "https://www.interactivebrokers.com/";

        //Polygon api key
        public const string PolygonApiKey = "_l66fHVP1P0_bCqNR2NXyXHF_T3soUoe";

        //Polygon base url
        public const string PolygonBaseUrl = "https://api.polygon.io/";

        //OpenAI api key
        public const string OpenAI_Api_Key = "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";

        //Alpha vantage api key
        public const string Alpha_Vantage_Api_Key = "BNLRDQ3I58J5U8Y3";


        //Alpha vantage base URl
        public const string AlphaVantageBaseUrl = "https://www.alphavantage.co/";


        //Commodaties api Key
        public const string Commodaties_API_Key = "1ef96isyhzmal4zohvz4vrybfu5ut3k8vsifhpa4y1ip55ml6c9by87l5j11";

        //Commodaties api base url
        public const string CommodatiesBaseUrl = "https://www.commodities-api.com/api/";

        //Commo Prices api KEy
        public const string Commo_Prices_API_Key = "xNMy1A4KAyFVf7yoDuxSrn9IMek0hn1W207yobQH7fGoyIy6P830tqH4fuWf";

        //Commo Prices api base url
        public const string CommoPricesBaseUrl = "https://api.commoprices.com/";
        #endregion

        #region MongoDB database
        //Cz5QF88D5cduZJFr - password
        // where there is sample_airbnb in the connection - name of the database
        public const string MongoConnectionString = "mongodb+srv://khanyithegreat:Cz5QF88D5cduZJFr@kbalphabusiness.f4bzy.mongodb.net/sample_airbnb?retryWrites=true&w=majority";
        public const string MongoDBBaseUrl = "https://data.mongodb-api.com/app/data-ceyts/endpoint/data/beta";
        public const string MongoDBApiKey = "UKYk6uIPyzawxOp54xsfanybhPqXrw2hGvhQDLsVBpfkiAQVhkneeJbYzoPdJf4l";
        #endregion
    }
}
