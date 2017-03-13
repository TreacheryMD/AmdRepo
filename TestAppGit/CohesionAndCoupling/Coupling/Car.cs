using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    class Car
    {
        public static Dictionary<int, string> carColours = new Dictionary<int, string>()
        {
            {1,"red"},
            {2,"blue"},
            {3,"green"}
        };
        public static int _colour = 1;
        private double _engineVol = 0;
        
        public Car(double engineVolum)
        {
            this._engineVol = engineVolum;
            
        }

        public static void SetColor(int color)
        {
            _colour = color;
        }


    }
}
