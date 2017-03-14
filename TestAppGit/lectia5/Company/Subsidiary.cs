using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class Subsidiary : Bank
    {
        public Subsidiary(string name, string address, Reg region, int? depots) : base(name, address, depots, region)
        {

        }

        public override void ShowInfo()
        {
            var dep = Depots == null ? "no depots" : $"depots: {Depots}";
            Console.WriteLine($"Subsidiary name: {Name}, address: {this.Address},{dep}, branch: {BranchId}, region: {Region}");
        }

    }
}
