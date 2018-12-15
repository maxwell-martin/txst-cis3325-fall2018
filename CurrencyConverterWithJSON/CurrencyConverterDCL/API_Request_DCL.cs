using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace CurrencyConverterDCL
{
    public class API_Request_DCL
    {
        public API_Request_DCL()
        {
            //Default constructor.
        }

        public string GetDataFromAPI_URL(string url)
        {
            WebClient client = new WebClient();

            string rawJSON = client.DownloadString(url);

            return rawJSON;
        }
    }
}
