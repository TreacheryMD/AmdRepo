using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Interfaces;
using MyModel.Testing_proxy;
using Ninject.Modules;

namespace MyModel.Helper
{
    class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<ICursManager>().To<ProxyConvertor>();
        }
    }
}
