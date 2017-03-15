using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class Bank
    {
        public enum Reg { Chisinau, AneniiNoi, Basarabeasca, Briceni, Cahul, Cantemir, Calarasi };
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Depots { get; set; }
        public string BranchId { get; set; }
        public Reg Region { get; set; }

        public List<Subsidiary> SubsidiaryList {get;set;}

        public Bank(string name, string address, int? depots, Reg region)
        {
            Name = name;
            Address = address;
            Depots = depots;
            BranchId = Branch.regDict[region];
            Region = region;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Bank name: {Name}, address: {Address}, depots: {Depots}, branch: {BranchId}, region: {Region}");
        }
    }
}
