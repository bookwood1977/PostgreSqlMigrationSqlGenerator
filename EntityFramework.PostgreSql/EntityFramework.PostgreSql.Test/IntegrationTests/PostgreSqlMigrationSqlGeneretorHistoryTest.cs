﻿using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Data.Entity.Migrations.Sql;
using Npgsql;
using NUnit.Framework;

namespace EntityFramework.PostgreSql.Test.IntegrationTests
{

    [TestFixture]
    public class PostgreSqlMigrationSqlGeneretorHistoryTest
    {

        private const string ConnectionString = "Server=127.0.0.1;Port=5432;Database=testEF6;User Id=postgres;Password=p0o9i8u7y6;CommandTimeout=20;Preload Reader = true;";
        private const string ProviderName = "Npgsql";


        [Test]
        public void GenerateInsertHistoryOperation()
        {


            var migrator = new DbMigrator(new LocalMigrationConfiguration());

            migrator.Update();


        }

        public class LocalMigrationConfiguration : DbMigrationsConfiguration<LocalPgContext>
        {
            public LocalMigrationConfiguration()
            {
                AutomaticMigrationDataLossAllowed = true;
                AutomaticMigrationsEnabled = false;
                SetSqlGenerator("Npgsql", new PostgreSqlMigrationSqlGenerator());
                MigrationsNamespace = "EntityFramework.PostgreSql.Test.IntegrationTests.Migrations";
                MigrationsAssembly = typeof (LocalPgContext).Assembly;
                TargetDatabase = new DbConnectionInfo(ConnectionString, ProviderName);
            }
        }

        public class LocalPgContext : DbContext//, IDbProviderFactoryResolver, IDbConnectionFactory
        {/*
            public DbProviderFactory ResolveProviderFactory(DbConnection connection)
            {
                return DbProviderFactories.GetFactory("Npgsql");
            }

            public DbConnection CreateConnection(string nameOrConnectionString)
            {
                return new NpgsqlConnection(nameOrConnectionString);
            }*/
        }
        /*
        public class LocalConfiguration : DbConfiguration
        {
            public LocalConfiguration()
            {

                // can't set this cos NpgsqlServices is internal
                SetProviderServices(
                    "Npgsql", provider: NpgsqlServices.Instance
                    );
            }

        }
        */
    }
}
