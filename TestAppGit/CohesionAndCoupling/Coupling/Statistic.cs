using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    class Statistic
    {
        int someField;
        string someField2;
        int someFIel3;

        public void SomeStatisticCalculation(Car car)
        {
            someFIel3 = car.Co2Emission;
            //someField2 = car.Colour;
            someField = car.Speed;

            //some logic with Fields
        } 
    }
}
