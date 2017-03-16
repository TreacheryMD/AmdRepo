using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    static class Poluation
    {
        private static int poluation = 0;

        public static void SomeCalc(Car car)
        {
            poluation += car.Co2Emission;

            //speed
        }
    }
}
