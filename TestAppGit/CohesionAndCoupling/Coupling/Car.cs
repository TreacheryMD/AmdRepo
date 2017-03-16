using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    class Car
    {
        public static string Colour { get; set; }
        private double _engineVol = 0;
        public int Speed { get; set; }
        public int Co2Emission { get; set; }

        public Car(double engineVolum)
        {
            this._engineVol = engineVolum;
        }

        public Car(double engineVolum, int speed = 0)
        {
            this._engineVol = engineVolum;
            Speed = speed;
        }

        public void Accelerate(int speed)
        {
            Speed += speed;
            if (speed <= 20) Co2Emission = 5;
            else if (speed > 20 && speed <= 40) Co2Emission = 10;
            else Co2Emission = 15;
        }

        public static List<Car> ModifyList(List<Car> carList,int cutLenght)
        {
            return carList.Take(carList.Count / cutLenght).ToList();
        }
    }
}
