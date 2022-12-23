using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoInsuranceAndClaimManagement.Migrations
{
    public partial class mg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Customer_Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone_Num = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Blood_Group = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Confirm_Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Vehicle_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Customer_Id = table.Column<int>(nullable: false),
                    Vehicle_Name = table.Column<string>(nullable: true),
                    Register_Num = table.Column<string>(nullable: true),
                    Vehicle_Type = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Register_Date = table.Column<DateTime>(nullable: false),
                    Vehicle_CC = table.Column<int>(nullable: false),
                    Vehicle_UsuageType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Vehicle_Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accident",
                columns: table => new
                {
                    Accident_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vehicle_Id = table.Column<int>(nullable: false),
                    Accident_Location = table.Column<string>(nullable: true),
                    Accident_Reason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accident", x => x.Accident_Id);
                    table.ForeignKey(
                        name: "FK_Accident_Vehicles_Vehicle_Id",
                        column: x => x.Vehicle_Id,
                        principalTable: "Vehicles",
                        principalColumn: "Vehicle_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claim",
                columns: table => new
                {
                    Claim_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vehicle_Id = table.Column<int>(nullable: false),
                    Claim_Amount = table.Column<int>(nullable: false),
                    Approved_Date = table.Column<DateTime>(nullable: false),
                    Approved_Amount = table.Column<int>(nullable: false),
                    Claim_Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claim", x => x.Claim_Id);
                    table.ForeignKey(
                        name: "FK_Claim_Vehicles_Vehicle_Id",
                        column: x => x.Vehicle_Id,
                        principalTable: "Vehicles",
                        principalColumn: "Vehicle_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Policy",
                columns: table => new
                {
                    Policy_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vehicle_Id = table.Column<int>(nullable: false),
                    Policy_Type = table.Column<string>(nullable: true),
                    Policy_Amount = table.Column<int>(nullable: false),
                    Aadhar_Num = table.Column<string>(nullable: true),
                    Start_Date = table.Column<DateTime>(nullable: false),
                    End_Date = table.Column<DateTime>(nullable: false),
                    policy_Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policy", x => x.Policy_Id);
                    table.ForeignKey(
                        name: "FK_Policy_Vehicles_Vehicle_Id",
                        column: x => x.Vehicle_Id,
                        principalTable: "Vehicles",
                        principalColumn: "Vehicle_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accident_Vehicle_Id",
                table: "Accident",
                column: "Vehicle_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Claim_Vehicle_Id",
                table: "Claim",
                column: "Vehicle_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Policy_Vehicle_Id",
                table: "Policy",
                column: "Vehicle_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_Customer_Id",
                table: "Vehicles",
                column: "Customer_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accident");

            migrationBuilder.DropTable(
                name: "Claim");

            migrationBuilder.DropTable(
                name: "Policy");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
