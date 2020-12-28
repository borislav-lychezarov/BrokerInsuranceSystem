using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrokerInsuranceData.Migrations
{
    public partial class AddCreationDateInInsurance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Insurances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 28, 20, 36, 39, 499, DateTimeKind.Utc).AddTicks(2752));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Insurances");
        }
    }
}
