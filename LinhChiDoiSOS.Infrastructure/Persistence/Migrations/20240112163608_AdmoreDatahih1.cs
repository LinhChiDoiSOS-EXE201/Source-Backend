using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdmoreDatahih1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_ComboService_ComboServiceId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_ComboServiceId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "ComboServiceId",
                table: "Booking");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "ComboService",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKL+7Ie1kSY5rBbIIbLh4jHNcMZvUC2NA12ClipzfZ0kRLtCAbBZcL3L6QYCSa6cQg==");

            migrationBuilder.CreateIndex(
                name: "IX_ComboService_ServiceId",
                table: "ComboService",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComboService_Service_ServiceId",
                table: "ComboService",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComboService_Service_ServiceId",
                table: "ComboService");

            migrationBuilder.DropIndex(
                name: "IX_ComboService_ServiceId",
                table: "ComboService");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "ComboService");

            migrationBuilder.AddColumn<Guid>(
                name: "ComboServiceId",
                table: "Booking",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED1S54djqUW3uAxCzkjWVy2rfPGdW/KDFE65ExiNlkwHg7M5IMbpfWfaNRL/NQ64aA==");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ComboServiceId",
                table: "Booking",
                column: "ComboServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_ComboService_ComboServiceId",
                table: "Booking",
                column: "ComboServiceId",
                principalTable: "ComboService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
