using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndKino.Migrations
{
    public partial class News : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameImg",
                table: "Movies",
                newName: "mainImageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mainImageName",
                table: "Movies",
                newName: "NameImg");
        }
    }
}
