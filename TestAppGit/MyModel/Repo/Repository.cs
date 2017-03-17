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
        List<BankAccount> _storage = new List<BankAccount>();

        public void Add(BankAccount acc)
        {
            _storage.Add(acc);
        }
        public void Add(List<BankAccount> accList)
        {
            foreach (var acc in accList)
            {
                _storage.Add(acc);
            }
        }

        public void Find()
        {
            throw new NotImplementedException();
        }

        public void Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<BankAccount> Get()
        {
            return _storage;
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
