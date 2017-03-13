using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Cohesion
{
    class Procedural
    {
        public bool checkWebServiceStatus(string linkWebservice)
        {
            return true; // for example it is Active right now and have response
        }

        public string queryFormat(string template, int param1, int param2)
        {
            var query = "some logic" + template; //etc
            return query;
        }

        public string GetData(string query, string urlWebService)
        {
            return "response data";
        }

        public void CreateReport(string responseData)
        {
            //your report Logic
        }
    }
}
