﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarWorkShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarWorkShops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactDetails_phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDetails_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDetails_Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDetails_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EncodedName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarWorkShops", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarWorkShops");
        }
    }
}
