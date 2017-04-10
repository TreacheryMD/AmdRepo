using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_SingleTon_Factory.SingleTon
{
    sealed class LoadBalancer
    {
        //eagerly initialized,thread safety  
        private static readonly LoadBalancer Instance = new LoadBalancer();

        // Type-safe generic list of _servers
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
                        {
                         new Server{ Name = "ServerI", Ip = "176.12.210.10" },
                         new Server{ Name = "ServerII", Ip = "156.12.210.11" },
                         new Server{ Name = "ServerIII", Ip = "130.12.210.12" },
                         new Server{ Name = "ServerIV", Ip = "125.12.210.13" },
                         new Server{ Name = "ServerV", Ip = "130.12.210.14" },
                         new Server{ Name = "ServerVi", Ip = "123.12.210.15" }
                        };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }
        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
