using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONDemoBCL
{
    public class City
    {
        //This class matches the objects that are coming from the JSON stream.

        private string id;
        private string cityName;
        private string cityState;
        private string cityPopulation;
        private string country;

        public string Id { get => id; set => id = value; }
        public string CityName { get => cityName; set => cityName = value; }
        public string CityState { get => cityState; set => cityState = value; }
        public string CityPopulation { get => cityPopulation; set => cityPopulation = value; }
        public string Country { get => country; set => country = value; }
    }
}
