﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankAccountForm.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2029, 6, 6, 22, 1, 58, 634, DateTimeKind.Local).AddTicks(9255)),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CardTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankCards_CardTypes_CardTypeId",
                        column: x => x.CardTypeId,
                        principalTable: "CardTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankCards_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerWorkDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerWorkDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerWorkDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Credits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Percent = table.Column<float>(type: "real", nullable: false),
                    BankCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Credits_BankCards_BankCardId",
                        column: x => x.BankCardId,
                        principalTable: "BankCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, "Debet" },
                    { 2, "Credit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankCards_CardTypeId",
                table: "BankCards",
                column: "CardTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankCards_CustomerId",
                table: "BankCards",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Credits_BankCardId",
                table: "Credits",
                column: "BankCardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerWorkDetails_CustomerId",
                table: "CustomerWorkDetails",
                column: "CustomerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credits");

            migrationBuilder.DropTable(
                name: "CustomerWorkDetails");

            migrationBuilder.DropTable(
                name: "BankCards");

            migrationBuilder.DropTable(
                name: "CardTypes");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}