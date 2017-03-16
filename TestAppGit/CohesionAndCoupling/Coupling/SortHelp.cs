using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
        class SortCarAsc : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                if (x.Speed > y.Speed) return 1;
                if (x.Speed < y.Speed) return -1;
                else return 0;
            }
        }
        class SortCarDesc : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                if (x.Speed > y.Speed) return -1;
                if (x.Speed < y.Speed) return 1;
                else return 0;
            }
        }
}
