using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspBetSample.DataBase.Migrations
{
    public partial class AddRssUrlToSource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RssUrl",
                table: "Sources",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RssUrl",
                table: "Sources");
        }
    }
}
