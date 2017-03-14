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
        private string _name;
        private string _address;
        private int? _depots;
        private string _branchId;
        private Reg _region;

        public Bank(string name, string address, int? depots, Reg region)
        {
            _name = name;
            _address = address;
            _depots = depots;
            _branchId = Branch.regDict[region];
            _region = region;
        }

        public int? Depots
        {
            get { return _depots; }
            set { _depots = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string BranchId
        {
            get { return _branchId; }
            set { _branchId = value; }
        }
        public Reg Region
        {
            get { return _region; }
            set { _region = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Bank name: {_name}, address: {_address}, depots: {_depots}, branch: {_branchId}, region: {_region}");
        }
    }
}
