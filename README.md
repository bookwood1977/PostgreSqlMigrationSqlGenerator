PostgreSqlMigrationSqlGenerator
===============================

Class to handle Entity Framework migrations with PostgreSQL


Requires
------------

1. Npgsql (you can find it in NuGet)
2. A database already creaded with a new schema called "dbo"


Installation
------------

1. Change your connection string into the file web.conf like this:

	<connectionStrings>
    <add name="DataContext" connectionString="Server=127.0.0.1;Port=5432;Database=db;User Id=postgres;Password=password;CommandTimeout=20;Preload Reader = true;" providerName="Npgsql" />
  </connectionStrings>