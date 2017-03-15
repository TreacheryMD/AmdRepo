using MyModel.Accounts;
using MyModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Repo
{
    class Repository : IRepository<BankAccount>
    {
        List<BankAccount> storage = new List<BankAccount>();

        public void Add(BankAccount acc)
        {
            storage.Add(acc);
        }

        public void Find()
        {
            throw new NotImplementedException();
        }

        public void Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
