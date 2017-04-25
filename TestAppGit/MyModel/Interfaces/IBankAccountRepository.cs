using MyModel.Accounts;
using MyModel.NhibernateTry.QuerryOverExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Interfaces
{
    public interface IBankAccountRepository
    {
        void Add<T>(T entity) where T : BankAccount;
        void Add<T>(List<T> lentity) where T : BankAccount;
        void Delete<T>(T entity) where T : BankAccount;
        T FindById<T>(int id) where T : BankAccount;
        List<T> GetAll<T>() where T : BankAccount;
        IList<QuerryOverExample1> RunQuerryOverExample2();
    }
}
