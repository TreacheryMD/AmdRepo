using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lect3Test
{
    class Human : LifeSpecies
    {
        public Human(string humanName, int humanAge)
        {
            this.Name = humanName;
            this.Age = humanAge;
        }
        public override void ShowInfo()
        {
            Console.Write("I am Human with ");
            base.ShowInfo();
        }
    }
}
