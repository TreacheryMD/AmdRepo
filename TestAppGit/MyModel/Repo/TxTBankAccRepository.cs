using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;
using MyModel.Interfaces;

namespace MyModel.Repo
{
    class TxTBankAccRepository : IRepository<BankAccount>
    {
        public void Add(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public void Add(List<BankAccount> lentity)
        {
            TxtReadWrite.WriteToTxt(lentity);
        }

        public void Delete(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public void Update(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public BankAccount FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BankAccount> GetAll()
        {
            return TxtReadWrite.ReadFromTxt();
        }
    }
}
