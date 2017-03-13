using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Cohesion
{
    class Communicational
    {
        //work on bankAccounts

        public void FindAccount(string owner)
        { 
        }

        public bool GetStatus(object account)
        {
            return false; //some logic, active or not active
        }

        public object GetAccount(string someCriteria)
        {
            return new object(); //return some account wich match criteria
        }
    }
}
