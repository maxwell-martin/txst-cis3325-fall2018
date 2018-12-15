using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JSONDemoDCL;

namespace JSONDemoBCL
{
    public class BusinessLogicClass
    {
        public BusinessLogicClass()
        {
            //Default constructor.
        }

        public List<City> RequestDataFromAPI_URL(string url)
        {
            List<City> listOfCities = new List<City>();
            DataAccessClass myDCL = new DataAccessClass();

            string strRawStream_JSON = myDCL.GetDataFromAPI_URL(url);

            listOfCities = JsonConvert.DeserializeObject<List<City>>(strRawStream_JSON);

            return listOfCities;
        }
    }
}
