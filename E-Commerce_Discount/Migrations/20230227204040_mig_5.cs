using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Discount.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_ManagerTypes_ManagerTypeId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Discounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerTypeId",
                table: "Discounts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_ManagerTypes_ManagerTypeId",
                table: "Discounts",
                column: "ManagerTypeId",
                principalTable: "ManagerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discounts_ManagerTypes_ManagerTypeId",
                table: "Discounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerTypeId",
                table: "Discounts",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerId",
                table: "Discounts",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Discounts_ManagerTypes_ManagerTypeId",
                table: "Discounts",
                column: "ManagerTypeId",
                principalTable: "ManagerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
