using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Clients;
using MyModel.Interfaces;
using NHibernate;

namespace MyModel.Repo
{
    class SqlPersonRepository : IPersonRepository
    {
        private readonly ISession _session;

        public SqlPersonRepository(ISession session)
        {
            _session = session;
        }

        public void Add<T>(T entity) where T : Person
        {
            _session.Save(entity);
        }

        public void Add<T>(List<T> lentity) where T : Person
        {
            foreach (var entity in lentity)
            {
                _session.Save(entity);
            }
        }

        public void Delete<T>(T entity) where T : Person
        {
            _session.Delete(entity);
        }

        public T FindById<T>(int id) where T : Person
        {
            return _session.Get<T>(id);
        }

        public List<T> GetAll<T>() where T : Person
        {
            return _session.QueryOver<T>().List().ToList();
        }
    }
}
