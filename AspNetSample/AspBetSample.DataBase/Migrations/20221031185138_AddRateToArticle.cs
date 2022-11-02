using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspBetSample.DataBase.Migrations
{
    public partial class AddRateToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Articles",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Articles");
        }
    }
}
