using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    static class Branch
    {
        public static Dictionary<Bank.Reg, string> regDict = new Dictionary<Bank.Reg, string>()
        {
            { Bank.Reg.Chisinau,"MD9999"},
            { Bank.Reg.AneniiNoi,"MD0001"},
            { Bank.Reg.Basarabeasca, "MD0002"},
            { Bank.Reg.Briceni,"MD0003"},
            { Bank.Reg.Cahul,"MD0004"},
            { Bank.Reg.Calarasi,"MD0005"},
            { Bank.Reg.Cantemir,"MD0006"}
        };
    }
}
