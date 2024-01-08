using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddmoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37dde3f4-d0c9-4477-97d6-ff29f677dccc", null, "Quản lí hệ thống", "AppIdentityRole", "Manager", "MANAGER" },
                    { "b9cf3487-3d04-4cbf-85b7-e33360566485", null, "Khách hàng", "AppIdentityRole", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDay", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fullname", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "871a809a-b3fa-495b-9cc2-c5d738a866cf", 0, null, new DateTime(2002, 6, 20, 8, 30, 56, 0, DateTimeKind.Unspecified), "445607b7-57f3-4092-9129-c8becc104929", "nhan@gmail.com", false, "Nguyễn Thành Nhân", null, true, null, "NHAN@GMAIL.COM", "NHANNGUYEN", "AQAAAAIAAYagAAAAELBNBVEaKLPiH0GMl0YJtU00Ss5zZODHsIRzLlxZlgsxD1ZOy8YBBpvTdyxPsp2+AQ==", "0961868641", false, "FHSBRSP7Q6SW6JWBVKCFBC6LKFR4MAR7", false, "NhanNguyen" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "37dde3f4-d0c9-4477-97d6-ff29f677dccc", "871a809a-b3fa-495b-9cc2-c5d738a866cf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9cf3487-3d04-4cbf-85b7-e33360566485");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37dde3f4-d0c9-4477-97d6-ff29f677dccc", "871a809a-b3fa-495b-9cc2-c5d738a866cf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37dde3f4-d0c9-4477-97d6-ff29f677dccc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDay",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
