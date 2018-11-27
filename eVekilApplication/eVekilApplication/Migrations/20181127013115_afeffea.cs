﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace eVekilApplication.Migrations
{
    public partial class afeffea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCard_AspNetUsers_UserId1",
                table: "ShoppingCard");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCard_UserId1",
                table: "ShoppingCard");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "ShoppingCard");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ShoppingCard",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCard_UserId",
                table: "ShoppingCard",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCard_AspNetUsers_UserId",
                table: "ShoppingCard",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCard_AspNetUsers_UserId",
                table: "ShoppingCard");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCard_UserId",
                table: "ShoppingCard");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ShoppingCard",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "ShoppingCard",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCard_UserId1",
                table: "ShoppingCard",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCard_AspNetUsers_UserId1",
                table: "ShoppingCard",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
