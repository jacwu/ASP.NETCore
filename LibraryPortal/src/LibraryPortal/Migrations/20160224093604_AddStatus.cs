using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace LibraryPortal.Migrations
{
    public partial class AddStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Book",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Status", table: "Book");
        }
    }
}
