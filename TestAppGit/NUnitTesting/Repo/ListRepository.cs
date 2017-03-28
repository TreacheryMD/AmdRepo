using NUnitTesting.Accounts;
using NUnitTesting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting.Repo
{
    class ListRepository<T> : IRepository<T>
    {
        private List<T> _storage = new List<T>();

        public void Add(T entity)
        {
            _storage.Add(entity);
        }
        public void Add(List<T> entityList)
        {
            foreach (var acc in entityList)
            {
                _storage.Add(acc);
            }
        }
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        public void Renew(List<T> list)
        {
            _storage = list;
        }

        public List<T> GetAll()
        {
            return _storage;
        }
    }
}
