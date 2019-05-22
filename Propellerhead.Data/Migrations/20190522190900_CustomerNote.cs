using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Propellerhead.Data.Migrations
{
    public partial class CustomerNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerNote",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Note = table.Column<string>(maxLength: 5000, nullable: true),
                    CustomerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerNote_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerNote_CustomerId",
                table: "CustomerNote",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerNote");
        }
    }
}
