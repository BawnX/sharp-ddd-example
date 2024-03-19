using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "example");

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "example",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    Address_Country = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    Address_Line1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Address_Line2 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Address_City = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Address_State = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Address_ZipCode = table.Column<string>(type: "text", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                schema: "example",
                table: "Customers",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers",
                schema: "example");
        }
    }
}
