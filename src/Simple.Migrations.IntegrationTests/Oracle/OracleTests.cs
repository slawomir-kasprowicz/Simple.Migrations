using System.Data.Common;
using NUnit.Framework;
using Simple.Migrations.IntegrationTests.Mssql;
using SimpleMigrations;
using SimpleMigrations.DatabaseProvider;

namespace Simple.Migrations.IntegrationTests.Oracle
{
    [TestFixture]
    public class OracleTests : TestsBase
    {
        protected override IMigrationStringsProvider MigrationStringsProvider { get; } = new OracleStringsProvider();

        protected override bool SupportConcurrentMigrators => true;

        protected override DbConnection CreateConnection() => null;//new Oracle.OracleConnection();();

        protected override IDatabaseProvider<DbConnection> CreateDatabaseProvider() => new MssqlDatabaseProvider(this.CreateConnection());

        protected override void Clean()
        {
            var connection = this.CreateConnection();
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = @"EXEC sp_MSforeachtable @command1 = ""DROP TABLE ?""";
                command.ExecuteNonQuery();
            }
        }
    }
}
