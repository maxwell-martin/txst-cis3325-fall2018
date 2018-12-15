using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace JSONDemoDCL
{
    public class DataAccessClass
    {
        public DataAccessClass()
        {
            //Default constructor.
        }

        public string GetDataFromAPI_URL(string url)
        {
            WebClient client = new WebClient();

            string strRawStream_JSON = client.DownloadString(url);

            return strRawStream_JSON;
        }
    }
}
