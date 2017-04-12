using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using IronPython.Modules;
using MyModel.Accounts;

namespace MyModel.NhibernateTry
{
    class CurrentAccountMap : ClassMap<CurrentAccount>
    {
        CurrentAccountMap()
        {
            Id(x=>x.Id);
            Map(x => x.AccNum);
            Map(x => x.Balance);
            Map(x => x.OpenDate);
            Map(x => x.Currency);
            Map(x => x.Person.FiscalCode);
            Map(x => x.Restricted);
            References(x => x.Person);
        }
    }
}
