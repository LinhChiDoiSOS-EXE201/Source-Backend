using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabaseMoreIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Admin");

            migrationBuilder.AddColumn<Guid>(
                name: "ComboServiceId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGlVLeUgPWZQLk8qgVyjG/+BMZsPbsmLHDu9JWVRFdgp0BYjTrA5ggDRxtRdGdsdBA==");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ComboServiceId",
                table: "Booking",
                column: "ComboServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_ApplicationUserId",
                table: "Admin",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_AspNetUsers_ApplicationUserId",
                table: "Admin",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_ComboService_ComboServiceId",
                table: "Booking",
                column: "ComboServiceId",
                principalTable: "ComboService",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_AspNetUsers_ApplicationUserId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_ComboService_ComboServiceId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ComboServiceId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Admin_ApplicationUserId",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "ComboServiceId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Admin");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIjGfpd4Gcj2weSxd6GbGsVDTJIRc6f4xxxxUKVSwgZUUD+NUcwbMd5whiBxCiMK1A==");
        }
    }
}
