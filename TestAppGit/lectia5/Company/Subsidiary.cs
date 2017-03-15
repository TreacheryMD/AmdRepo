using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lectia5.Bank;

namespace lectia5
{
    class Subsidiary 
    {
        public string SubName { get; set; }
        public string SubAddres { get; set; }
        public Reg SubRegion { get; set; }
        public string BranchId { get; set; }


        public Subsidiary(string name, string address, Reg region) 
        {
            SubName = name;
            SubAddres = address;
            SubRegion = region;
            BranchId = Branch.regDict[region];
        }

        //public override void ShowInfo()
        //{
        //    var dep = Depots == null ? "no depots" : $"depots: {Depots}";
        //    Console.WriteLine($"Subsidiary name: {Name}, address: {this.Address},{dep}, branch: {BranchId}, region: {Region}");
        //}

    }
}
