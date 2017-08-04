using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GummyBearKingdomTokyo.Migrations
{
    public partial class validation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                maxLength: 60,
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "CountryOfOrigin",
                table: "Product",
                maxLength: 60,
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryOfOrigin",
                table: "Product",
                nullable: true);
        }
    }
}
