using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    class Car
    {
        public string Colour { get; set; }
        private double _engineVol = 0;
        
        public Car(double engineVolum)
        {
            this._engineVol = engineVolum;
        }
    }
}
