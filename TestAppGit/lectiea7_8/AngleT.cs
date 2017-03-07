using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectiea7_8
{
    class AngleT
    {
        private int v;

        //numeric fields: degrees, minutes, seconds

        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public bool IsNegative { get; set; }

        //need manually to set some data to the properties
        public AngleT()
        {

        }
        public AngleT(int degrees, int minutes,int seconds)
        {
            this.Degrees = degrees;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        // fromDouble
        public static AngleT MakeFromDouble(double num)
        {
            int degree = (int)num;
            double preM = Convert.ToDouble(num - degree) * 60;
          
            var minutes = (int)preM;
            var s = num - degree;
            var s2 = (double)minutes / 60;
            var seconds = Math.Round((Math.Abs(s) - s2) * 3600);

            return new AngleT(degree, minutes, (int)seconds);
        }

        public static double ConvertDegreeAngleToDouble(AngleT a)
        {
            double degrees = a.Degrees;
            double minutes = a.Minutes;
            double seconds = a.Seconds;
            var result = degrees + minutes / 60 + seconds / 3600;
            return result;
        }

        public static AngleT operator +(AngleT a1, AngleT a2)
        {
            double angle = ConvertDegreeAngleToDouble(a1) + ConvertDegreeAngleToDouble(a2);

            while (angle < -180.0) angle += 360.0;
            while (angle > 180.0) angle -= 360.0;

            return MakeFromDouble(angle);
        }


        public override string ToString()
        {
            var degrees = this.IsNegative ? -this.Degrees : this.Degrees;
            return string.Format("{0}° {1:00}' {2:00}\"",degrees,this.Minutes,this.Seconds);
        }
    }
}
