using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lect3Test
{
    public class Alien : LifeSpecies
    {
        public Alien(string alienName,int alienAge)
        {
            this.Name = alienName;
            this.Age = alienAge;
        }

        public override void ShowInfo()
        {
            Console.Write("I am Alien with ");
            base.ShowInfo();
        }

    }
}
