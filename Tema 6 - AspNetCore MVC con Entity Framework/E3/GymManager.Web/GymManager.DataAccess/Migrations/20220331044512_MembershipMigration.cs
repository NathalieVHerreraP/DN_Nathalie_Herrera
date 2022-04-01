using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.DataAccess.Migrations
{
    public partial class MembershipMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipTypes_MembershipTypeId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipTypeId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "Members");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "MembershipTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MembershipTypes_MemberId",
                table: "MembershipTypes",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_MembershipTypes_Members_MemberId",
                table: "MembershipTypes",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembershipTypes_Members_MemberId",
                table: "MembershipTypes");

            migrationBuilder.DropIndex(
                name: "IX_MembershipTypes_MemberId",
                table: "MembershipTypes");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "MembershipTypes");

            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipTypeId",
                table: "Members",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipTypes_MembershipTypeId",
                table: "Members",
                column: "MembershipTypeId",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
