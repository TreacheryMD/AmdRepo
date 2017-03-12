using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5.Interfaces
{
    interface IRepository
    {
        void Add();
        void Remove();
        void Get(string id);
        void Find();
       
    }
}
