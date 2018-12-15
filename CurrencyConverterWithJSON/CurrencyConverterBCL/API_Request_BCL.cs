using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CurrencyConverterDCL;
using Newtonsoft.Json.Linq;

namespace CurrencyConverterBCL
{
    public class API_Request_BCL
    {
        public API_Request_BCL()
        {
            //Default constructor.
        }

        public Dictionary<string, double> RequestDataFromAPI_URL(string url)
        {
            API_Request_DCL myDCL = new API_Request_DCL();

            string rawJSON = myDCL.GetDataFromAPI_URL(url);

            JObject rootObject = JObject.Parse(rawJSON);

            var rates = rootObject.Value<JObject>("rates").Properties();

            Dictionary<string, double> ratesDictionary = rates.ToDictionary(kvPair => kvPair.Name, kvPair => (double)kvPair.Value);

            return ratesDictionary;
        }
    }
}