using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabaseMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "CourseDetail");

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Customer",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Conlusion",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentStep",
                table: "CourseDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENHOTWufz9WsKH9/ewIIl0shJmKMFpJQO23XrvfIdZEzUrNmEyt9gCykFKwIniW5Mw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Conlusion",
                table: "CourseDetail");

            migrationBuilder.DropColumn(
                name: "ContentStep",
                table: "CourseDetail");

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "CourseDetail",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO/brsK8lRqWWIU5V04jx3MayJA70aSfwUcG9VZBqvyyL/idhkBPJ3wuQaaKOQXlBw==");
        }
    }
}
