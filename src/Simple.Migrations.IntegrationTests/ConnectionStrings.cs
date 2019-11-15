using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace Simple.Migrations.IntegrationTests
{
    public static class ConnectionStrings
    {
        public static readonly string SQLiteDatabase = "database.sqlite";
        public static readonly string SQLite = "DataSource=" + SQLiteDatabase;
        public static readonly string MSSQL = @"Server=.;Database=SimpleMigratorTests;Trusted_Connection=True;";
        public static readonly string MySQL = @"Server=localhost;Database=SimpleMigrator;Uid=SimpleMigrator;Pwd=SimpleMigrator;";
        public static readonly string PostgreSQL = @"Server=localhost;Port=5432;Database=SimpleMigrator;User ID=SimpleMigrator;Password=SimpleMigrator";
        public static readonly string OracleSQL = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=tdgdarkbasic006.powelasa.powel.com)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=MFRRDB_Tests;Password=mfrrAdmin!";
    }
}
