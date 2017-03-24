using MyModel.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.Interfaces
{
    public interface IRepository<T> 
    {
        void Add(T entity);
        void Add(List<T> lentity );
        void Delete(T entity);
        void Update(T entity);
        T FindById(int id);
        List<T> GetAll();
    }
}
