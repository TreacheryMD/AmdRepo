﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class SubsidiaryEqualityComparer : EqualityComparer<Subsidiary>
    {
        public override bool Equals(Subsidiary x, Subsidiary y)
        {
            return x.BranchId == y.BranchId && x.SubName == y.SubName;
        }

        public override int GetHashCode(Subsidiary obj)
        {
            return (obj.SubName + ";" + obj.BranchId).GetHashCode();
        }
    }
}
