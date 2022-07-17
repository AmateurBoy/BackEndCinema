using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndKino.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name:"Pass",
                table: "Accounts"
                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
