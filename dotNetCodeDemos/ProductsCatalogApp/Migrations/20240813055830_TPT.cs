﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCatalogApp.Migrations
{
    /// <inheritdoc />
    public partial class TPT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_People_SuppliersId",
                table: "ProductSupplier");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.DropColumn(
                name: "GST",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "People");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_People_Id",
                        column: x => x.Id,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    GST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_People_Id",
                        column: x => x.Id,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_Suppliers_SuppliersId",
                table: "ProductSupplier",
                column: "SuppliersId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSupplier_Suppliers_SuppliersId",
                table: "ProductSupplier");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GST",
                table: "People",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSupplier_People_SuppliersId",
                table: "ProductSupplier",
                column: "SuppliersId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
