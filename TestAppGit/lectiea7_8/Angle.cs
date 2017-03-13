using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectiea7_8
{
    class Angle : ICloneable
    {
        #region property
        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public bool IsNegative { get; set; }

        #endregion

        #region Constructors
        //need manually to set some data to the properties
        public Angle()
        {

        }
        public Angle(int degrees, int minutes,int seconds)
        {
            this.Degrees = degrees;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        #endregion 

        #region Methods
        // fromDouble
        public static Angle MakeFromDouble(double num)
        {
            int degree = (int)num;
            double preM = Convert.ToDouble(num - degree) * 60;
          
            var minutes = (int)preM;
            var s = num - degree;
            var s2 = (double)minutes / 60;
            var seconds = Math.Round((Math.Abs(s) - Math.Abs(s2)) * 3600);

            return new Angle(degree, minutes, (int)seconds);
        }

        public static double ConvertDegreeAngleToDouble(Angle a)
        {
            double degrees = a.Degrees;
            double minutes = a.Minutes;
            double seconds = a.Seconds;
            var result = degrees + minutes / 60 + seconds / 3600;
            return result;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion

        #region Operators
        public static Angle operator +(Angle a1, Angle a2)
        {
            double angle = ConvertDegreeAngleToDouble(a1) + ConvertDegreeAngleToDouble(a2);

            while (angle < -180.0) angle += 360.0;
            while (angle > 180.0) angle -= 360.0;

            return MakeFromDouble(angle);
        }

        public static Angle operator -(Angle a1, Angle a2)
        {
            //return MakeFromDouble(ConvertDegreeAngleToDouble(a1) - ConvertDegreeAngleToDouble(a2));

            var test = ConvertDegreeAngleToDouble(a1) - ConvertDegreeAngleToDouble(a2);
            var test2 = MakeFromDouble(test);

            return MakeFromDouble(ConvertDegreeAngleToDouble(a1) - ConvertDegreeAngleToDouble(a2));
        }

        public static Angle operator /(Angle a1, Angle a2)
        {
            return MakeFromDouble(ConvertDegreeAngleToDouble(a1) / ConvertDegreeAngleToDouble(a2));
        }

        public static Angle operator *(Angle a1, Angle a2)
        {
            return MakeFromDouble(ConvertDegreeAngleToDouble(a1) * ConvertDegreeAngleToDouble(a2));
        }

        public static bool operator <(Angle a1, Angle a2)
        {
            if (ConvertDegreeAngleToDouble(a1) < ConvertDegreeAngleToDouble(a2)) return true;
            else return false;
        }
        public static bool operator >(Angle a1, Angle a2)
        {
            if (ConvertDegreeAngleToDouble(a1) > ConvertDegreeAngleToDouble(a2)) return true;
            else return false;
        }

        public static bool operator <=(Angle a1, Angle a2)
        {
            if (ConvertDegreeAngleToDouble(a1) <= ConvertDegreeAngleToDouble(a2)) return true;
            else return false;
        }
        public static bool operator >=(Angle a1, Angle a2)
        {
            if (ConvertDegreeAngleToDouble(a1) >= ConvertDegreeAngleToDouble(a2)) return true;
            else return false;
        }

        public static implicit operator string(Angle a)
        {
            return a.ToString();
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            var degrees = this.IsNegative ? -this.Degrees : this.Degrees;
            return string.Format("{0}° {1:00}' {2:00}\"",degrees,this.Minutes,this.Seconds);
        }

        #endregion
    }
}
