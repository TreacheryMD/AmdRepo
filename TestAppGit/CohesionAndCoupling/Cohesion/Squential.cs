using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Cohesion
{
    class Squential
    {
        private string UseClothes(string clothes) {return "dirt clothes";}

        private string WashClothes(string dirtClothes) { return "wet clothes"; }

        private string DryClothes(string wetClothes) { return "dried clothes"; }

        public string IroningClothes(string driedClothes) { return "readyToUseClothes"; }

    }
}
