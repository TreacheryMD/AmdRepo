using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace MyModel.NhibernateTry
{
    class SessionFactoryInit
    {
        public class SessionGenerator
        {
            #region Public members

            public ISession GetSession()
            {
                return SessionFactory.OpenSession();
            }

            public static SessionGenerator Instance
            {
                get { return _sessionGenerator; }
            }

            #endregion

            #region Non-public static members

            private static ISessionFactory CreateSessionFactory()
            {
                FluentConfiguration configuration = Fluently.Configure()
                                                            .Database(MsSqlConfiguration.MsSql2012
                                                                                        .ConnectionString(
                                                                                            builder =>
                                                                                            builder.Database(
                                                                                                "NHibernateTEST")
                                                                                                   .Server(
                                                                                                       @"DESKTOP-F879NAM\SQLEXPRESS")
                                                                                                   .TrustedConnection()))
                                                            .Mappings(
                                                                x =>
                                                                x.FluentMappings.AddFromAssembly(typeof(PersonMap).Assembly))

                                                            .ExposeConfiguration(
                                                                cfg => new SchemaUpdate(cfg).Execute(false, true));


                return configuration.BuildSessionFactory();
            }

            #endregion

            #region Non-public members

            private SessionGenerator()
            {
            }

            private static readonly SessionGenerator _sessionGenerator = new SessionGenerator();
            private static readonly ISessionFactory SessionFactory = CreateSessionFactory();

            #endregion
        }
    }
}
