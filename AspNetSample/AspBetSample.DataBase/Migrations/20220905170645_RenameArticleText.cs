using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspBetSample.DataBase.Migrations
{
    public partial class RenameArticleText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Articles",
                newName: "FullText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullText",
                table: "Articles",
                newName: "Text");
        }
    }
}
