using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lect3Test
{
    public class LifeSpecies
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name} and Age: {this.Age} ");
        }

    }
}
