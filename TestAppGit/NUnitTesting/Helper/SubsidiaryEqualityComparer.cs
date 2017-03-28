using NUnitTesting.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting.Helper
{
    class SubsidiaryEqualityComparer : EqualityComparer<Subsidiary>
    {
        public override bool Equals(Subsidiary x, Subsidiary y)
        {
            return x.BranchId == y.BranchId && x.Name == y.Name;
        }

        public override int GetHashCode(Subsidiary obj)
        {
            return (obj.Name + ";" + obj.BranchId).GetHashCode();
        }
    }
}
