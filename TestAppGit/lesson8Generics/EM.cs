using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8Generics
{
    public static class EM
    {
            public static int[] FindAllIndexof<T>(this IEnumerable<T> values, T val)
            {
                return values.Select((b, i) => object.Equals(b, val) ? i : -1).Where(i => i != -1).ToArray();
            }
    }
}
