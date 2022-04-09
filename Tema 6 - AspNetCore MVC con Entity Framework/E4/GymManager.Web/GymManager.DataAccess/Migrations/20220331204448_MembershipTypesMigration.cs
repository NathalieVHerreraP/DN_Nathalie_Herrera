using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.DataAccess.Migrations
{
    public partial class MembershipTypesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MonthsDuration",
                table: "MembershipTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartingDate",
                table: "MembershipTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);      
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthsDuration",
                table: "MembershipTypes");

            migrationBuilder.DropColumn(
                name: "StartingDate",
                table: "MembershipTypes");
        }
    }
}
