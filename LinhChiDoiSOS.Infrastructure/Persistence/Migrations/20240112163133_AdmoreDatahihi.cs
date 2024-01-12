using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdmoreDatahihi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetail_Service_ServiceId",
                table: "BookingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_ComboService_ComboServiceId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ComboServiceId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ComboServiceId",
                table: "Service");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "BookingDetail",
                newName: "ComboServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingDetail_ServiceId",
                table: "BookingDetail",
                newName: "IX_BookingDetail_ComboServiceId");

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "ServiceDetail",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED1S54djqUW3uAxCzkjWVy2rfPGdW/KDFE65ExiNlkwHg7M5IMbpfWfaNRL/NQ64aA==");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetail_ComboService_ComboServiceId",
                table: "BookingDetail",
                column: "ComboServiceId",
                principalTable: "ComboService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingDetail_ComboService_ComboServiceId",
                table: "BookingDetail");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "ServiceDetail");

            migrationBuilder.RenameColumn(
                name: "ComboServiceId",
                table: "BookingDetail",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingDetail_ComboServiceId",
                table: "BookingDetail",
                newName: "IX_BookingDetail_ServiceId");

            migrationBuilder.AddColumn<Guid>(
                name: "ComboServiceId",
                table: "Service",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGlVLeUgPWZQLk8qgVyjG/+BMZsPbsmLHDu9JWVRFdgp0BYjTrA5ggDRxtRdGdsdBA==");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ComboServiceId",
                table: "Service",
                column: "ComboServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingDetail_Service_ServiceId",
                table: "BookingDetail",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_ComboService_ComboServiceId",
                table: "Service",
                column: "ComboServiceId",
                principalTable: "ComboService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
