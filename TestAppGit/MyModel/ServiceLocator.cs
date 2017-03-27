using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel
{
    public class ServiceLocator : IServiceLocator
    {
        private IDictionary<object, object> services;

        internal ServiceLocator()
        {
            services = new Dictionary<object, object>();

            // maping will be here
            //ervices.Add(typeof(IServiceA), new ServiceA());
            //services.Add(typeof(IServiceB), new ServiceB());
            //services.Add(typeof(IServiceC), new ServiceC());
        }

        public T GetService<T>()
        {
            try
            {
                return (T)services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }
}
