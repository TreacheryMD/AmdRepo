using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Modules;
using MyModel.Accounts;
using MyModel.Clients;
using MyModel.Interfaces;
using MyModel.NhibernateTry.QuerryOverExample;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace MyModel.Repo
{
    public class SqlBankAccountRepository : IBankAccountRepository
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

        public IList<QuerryOverExample1> RunQuerryOverExample2()
        {
            BankAccount bankAccount = null;

            CurrentAccount currentAccount = null;
            CreditAccount creditAccount = null;
            Person person = null;

            QuerryOverExample1 row = null;

            return _session.QueryOver(() => bankAccount)
                .JoinAlias(() => bankAccount.Person, () => person)
                
               // .Where(b => b is CurrentAccount)

                .SelectList(list => list
                    .Select(() => bankAccount.AccNum).WithAlias(() => row.CurrentAccount)
                    .Select(() => bankAccount.OpenDate).WithAlias(() => row.CAOpenDate)
                 
                    .Select(() => person.FiscalCode).WithAlias(() => row.FiscalCode)
                    .Select(() => person.FirstName).WithAlias(() => row.FirstName)
                    .Select(() => person.LastName).WithAlias(() => row.LastName)
                    )
                .TransformUsing(Transformers.AliasToBean<QuerryOverExample1>())
                .List<QuerryOverExample1>();

        }





    }
}
