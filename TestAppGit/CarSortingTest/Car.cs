using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSortingTest
{
    class Car 
    {
        private int _year;
        private string _model;
        private int _speed;

        public Car()
        {
            this._year = 2000;
            this._model = "BMW";
            this._speed = 0;
        }

        public Car(string model, int year, int speed)
        {
            this._year = year;
            this._model = model;
            this._speed = speed;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public void AccSpeed(int speedIncrement)
        {
            //Add check for speed limit ranges
            Speed += speedIncrement;
        }

        public void DecSpeed(int speedDecrement)
        {
            //Add check for speed limit ranges
            Speed -= speedDecrement;
        }

        public override string ToString()
        {
            return ($"Model:{this.Model}, speed:{this.Speed}, year: {this.Year}");
        }

        public static void ShowFromEnum(IEnumerable<Car> cars)
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("_________________________________");
        }
    }
}
