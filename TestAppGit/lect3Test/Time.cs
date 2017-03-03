using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lect3Test
{
    class Time
    {
        private static int _humanTotalTime = 0;
        private static int  _alienTotalTime = 0;

        static Time()
        {
            _humanTotalTime = DateTime.Now.Year;
            _alienTotalTime = DateTime.Now.Year;

            Console.WriteLine($"Static constructor sets current year for humans and aliens to: {DateTime.Now.Year}");
        }

        public static void TimePassed(Human human, int howMuchYearPassed)
        {
            human.Age += howMuchYearPassed;
            _humanTotalTime += howMuchYearPassed;
        }

        public static void TimePassed(Alien alien, int howMuchYearPassed)
        {
            alien.Age += howMuchYearPassed;
            _humanTotalTime += howMuchYearPassed;
        }

        public void ShowHumanTime()
        {
            Console.WriteLine($"{_humanTotalTime} years has been passed for humans");
        }

        public void ShowAlienTime()
        {
            Console.WriteLine($"{_alienTotalTime} years has been passed for humans");
            
        }
        public static void GetAllTime(out int i)
        {
            i = _humanTotalTime+ _alienTotalTime;
        }
    
    }
}
