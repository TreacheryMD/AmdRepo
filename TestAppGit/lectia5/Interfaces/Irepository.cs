using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5.Interfaces
{
    interface IRepository<T> where T: BankAccount
    {
        void Add(BankAccount account);
        void Remove();
        void Get(string id);
        void Find();
       
    }
}
