using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Discount.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManagerName",
                table: "ManagerTypes",
                newName: "Name");

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerId",
                table: "Discounts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerTypeId",
                table: "Discounts",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ManagerTypeId",
                table: "Discounts",
                column: "ManagerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_ManagerTypes_ManagerTypeId",
                table: "Discounts",
                column: "ManagerTypeId",
                principalTable: "ManagerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_ManagerTypes_ManagerTypeId",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_ManagerTypeId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "ManagerTypeId",
                table: "Discounts");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ManagerTypes",
                newName: "ManagerName");
        }
    }
}
