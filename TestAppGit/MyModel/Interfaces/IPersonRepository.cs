using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;
using MyModel.Clients;

namespace MyModel.Interfaces
{
    public interface IPersonRepository
    {
        void Add<T>(T entity) where T : Person;
        void Add<T>(List<T> lentity) where T : Person;
        void Delete<T>(T entity) where T : Person;
        T FindById<T>(int id) where T : Person;
        List<T> GetAll<T>() where T : Person;
    }
}
