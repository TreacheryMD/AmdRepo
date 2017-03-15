using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5.TemporarExamples
{
    class Result
    {
        public string Name { get; set; }
        public IEnumerable<Order> Collection { get; set; }
        public Result(string name, IEnumerable<Order> collection)
        {
            this.Name = name;
            this.Collection = collection;
        }
    }
}
