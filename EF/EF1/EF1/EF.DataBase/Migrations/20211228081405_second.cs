using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.DataBase.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TarrifId",
                table: "Timeslots");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TarrifId",
                table: "Timeslots",
                type: "uuid",
                nullable: true);
        }
    }
}
