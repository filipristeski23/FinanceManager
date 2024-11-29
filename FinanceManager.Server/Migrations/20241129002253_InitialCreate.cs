using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceManager.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EachPurchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillAmount = table.Column<int>(type: "int", nullable: false),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectOption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EachPurchases", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EachPurchases");
        }
    }
}
