using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Cohesion
{
    class Temporal
    {
        //this fucntion will be called after catching an exception when FileStream has error
        // (a particular time in program execution )

        public static void CloseFile()
        {
            //close file
        }

        public static void CreateErrorLog()
        {
            //save errorLog.txt somewhere in Debug folder
        }

        public static void NotifyUser()
        {
            //some notification
        }
    }
}
