using MyModel.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Interfaces
{
    interface IRepository<T> where T : BankAccount
    {
        void Add(BankAccount account);
        void Remove();
        void Get(string id);
        void Find();

    }
}
