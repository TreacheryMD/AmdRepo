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

        //public  static Car[] Sort(Car[] thisArray)
        //{
        //    int length = thisArray.Length;
        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        for (int j = 0; j < length - 1 - i; j++)
        //        {
        //            if (thisArray[j].Speed < thisArray[j + 1].Speed)
        //            {
        //                var num = thisArray[j];
        //                thisArray[j] = thisArray[j + 1];
        //                thisArray[j + 1] = num;
        //            }
        //        }
        //    }
        //    return thisArray;
        //}
    }
}
