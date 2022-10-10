using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspBetSample.DataBase.Migrations
{
    public partial class CreateSampleDataForDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var onlinerId = Guid.NewGuid().ToString("D");
            var insertSources = "INSERT INTO [dbo].[Sources] ([Id] ,[Name] ,[Url] ,[SourceType]) " +
               $"VALUES ('{onlinerId}', 'Onliner' , 'https:\\onliner.by' , 0)";

            migrationBuilder.Sql(insertSources);

            var insertArticles =
                "INSERT INTO [dbo].[Articles] ([Id] ,[Title] ,[ShortDescription] ,[FullText] ,[PublicationDate] ,[SourceId]) VALUES " +
                $"('{Guid.NewGuid().ToString("D")}' ,'Article1' , 'ShortDescription 1' , 'Some text 1', '2022-10-05 19:13:00.197' ,'{onlinerId}')," +
                $"('{Guid.NewGuid().ToString("D")}' ,'Article2' , 'ShortDescription 2' , 'Some text 2', '2022-10-05 19:13:00.197' ,'{onlinerId}')";


            migrationBuilder.Sql(insertArticles);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
