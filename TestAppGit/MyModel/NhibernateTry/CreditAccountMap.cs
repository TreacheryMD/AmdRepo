using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions;
using FluentNHibernate.Mapping;
using MyModel.Accounts;

namespace MyModel.NhibernateTry
{
    class CreditAccountMap : ClassMap<CreditAccount>
    {
        CreditAccountMap()
        {
           // IClassConvention
           // Table("tblCreditAccounts");

            Id(x => x.Id);
            Map(x => x.AccNum);
            Map(x => x.Balance);
            Map(x => x.OpenDate);
            Map(x => x.Currency);
            Map(x => x.Reimbursement);
            References(x => x.Person);
        }
    }
}
