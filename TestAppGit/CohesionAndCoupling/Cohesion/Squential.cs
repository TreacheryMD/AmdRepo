using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Cohesion
{
    class Squential
    {
        public string UseClothes() {return "dirt clothes";}

        public string WashClothes() { return "wet clothes"; }

        public string DryClothes() { return "dried clothes"; }

        public string IroningClothes() { return "readyToUseClothes"; }

    }
}
