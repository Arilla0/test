using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    BrandName = table.Column<string>(nullable: true),
                    isAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarOrders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created = table.Column<DateTime>(nullable: false),
                    customerId = table.Column<int>(nullable: false),
                    modelName = table.Column<string>(nullable: true),
                    trimNane = table.Column<string>(nullable: true),
                    engine = table.Column<string>(nullable: true),
                    FuelTypes = table.Column<int>(nullable: false),
                    GearTypes = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    bankLoanDuration = table.Column<int>(nullable: false),
                    bankLoanDownPayment = table.Column<double>(nullable: false),
                    bankLoanMonthlyPayment = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOrders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarTrims",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    carModelId = table.Column<int>(nullable: false),
                    isAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTrims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarVariant",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    engine = table.Column<string>(nullable: true),
                    FuelTypes = table.Column<int>(nullable: false),
                    GearTypes = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    isAvailable = table.Column<bool>(nullable: false),
                    carTrimId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarVariant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CarOrders");

            migrationBuilder.DropTable(
                name: "CarTrims");

            migrationBuilder.DropTable(
                name: "CarVariant");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
