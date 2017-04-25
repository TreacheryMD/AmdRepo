using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using IronPython.Modules;
using MyModel.Clients;

namespace MyModel.NhibernateTry
{
    class PersonMap : ClassMap<Person>
    {
        PersonMap()
        {
            //Table("tblPerson");

            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.BirthDate);
            Map(x => x.FiscalCode);
            Map(x => x.Gender);
        }
    }
}
