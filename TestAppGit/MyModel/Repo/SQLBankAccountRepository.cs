using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;
using MyModel.Interfaces;
using NHibernate;

namespace MyModel.Repo
{
    class SqlBankAccountRepository : IBankAccountRepository
    {

        private readonly ISession _session;

        public SqlBankAccountRepository(ISession session)
        {
            _session = session;
        }

        public void Add<T>(List<T> lentity) where T : BankAccount
        {
            foreach (var entity in lentity)
            {
                _session.Save(entity);
            }
        }

        public void Add<T>(T entity) where T : BankAccount
        {
            _session.Save(entity);
        }

        public void Delete<T>(T entity) where T : BankAccount
        {
            _session.Delete(entity);
        }

        public T FindById<T>(int id) where T : BankAccount
        {
            return _session.Get<T>(id);
        }

        public List<T> GetAll<T>() where T : BankAccount
        {
            return  _session.QueryOver<T>().List().ToList();
        }
    }
}
