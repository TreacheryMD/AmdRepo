using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lect3Test
{
    class Program
    {

         static int _totalPlanets; // not protected sharing resources

        //static object _lock = new object();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! New era has begun!");

            Time timeStarted = new Time();

            Human firstHuman = new Human("Adam",20);
            //firstHuman.ShowInfo();
            Human secondHuman = new Human("Eva", 19);
            //secondHuman.ShowInfo();

            Alien firstAlien = new Alien("Entropy", 435);
            //firstAlien.ShowInfo();

            Alien secondAlien = new Alien("Enigma", 420);
            //secondAlien.ShowInfo();


            //boxing
            List<object> allSpecies = new List<object>();
            allSpecies.Add("Group of Humans:");
            allSpecies.Add(firstHuman);
            allSpecies.Add(secondHuman);
            allSpecies.Add("Group of Aliens");
            allSpecies.Add(firstAlien);
            allSpecies.Add(secondAlien);

            //unboxing
            for (var i = 1; i < 3; i++)
            {
                var thisHuman = (Human)allSpecies[i];
                thisHuman.ShowInfo();
            }

            for (int i = 4; i < 6; i++)
            {
                var thisAlien = (Alien)allSpecies[i];
                thisAlien.ShowInfo();
            }

            Time.TimePassed(secondHuman, 30);
            Time.TimePassed(firstHuman, 30);

            Time.TimePassed(firstAlien, 200);
            Time.TimePassed(secondAlien, 500);

            int wholeTime = 0;
            Time.GetAllTime(out wholeTime);
            Console.WriteLine($"Whole time is :{wholeTime}");


            Thread T1 = new Thread(Program.AddOneMilionPlanets);
            Thread T2 = new Thread(Program.AddOneMilionPlanets);
            Thread T3 = new Thread(Program.AddOneMilionPlanets);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();


            Console.WriteLine($"Total planets: {_totalPlanets}");
        }

        public static void AddOneMilionPlanets()
        {
            for (int i = 0; i < 1000000; i++)
            {
                _totalPlanets++; //not thread save
                //Interlocked.Increment(ref _totalPlanets);

                //sau locking (numai 1 thread)
                //lock (_lock)
                //{
                //    _totalPlanets++;
                //}

            }
        }
    }

}
