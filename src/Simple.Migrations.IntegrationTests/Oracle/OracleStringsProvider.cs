namespace Simple.Migrations.IntegrationTests.Oracle
{
    public class OracleStringsProvider : IMigrationStringsProvider
    {
        public string CreateUsersTableUp => @"CREATE TABLE Users (
                [Id] [int] IDENTITY(1,1)  PRIMARY KEY NOT NULL,
                Name TEXT NOT NULL
            );";

        public string CreateUsersTableDown => "DROP TABLE Users";
    }
}
