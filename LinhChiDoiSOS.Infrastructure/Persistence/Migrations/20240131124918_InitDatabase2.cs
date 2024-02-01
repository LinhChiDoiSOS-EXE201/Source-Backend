using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaymentMethod",
                table: "Payment",
                newName: "PaymentStatus");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MerchantId",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "PaidAmount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentContent",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentCurrency",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentDate",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentDestinationId",
                table: "Payment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PaymentLanguage",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentLastMessage",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentRefId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "RequiredAmount",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Merchant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MerchantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantWebLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantIpnUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantReturnUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecretKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDestination",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesParentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortIndex = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDestination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSignature",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SignValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignAlgo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignOwn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSignature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSignature_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TranMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranPayload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TranAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TranDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TranRefId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransaction_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PaymentNotification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentRefId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotiDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotiContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotiAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NotiMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotiSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotiNotiStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotiResDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotiResMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotiResHttpCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MerchantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentNotification_Merchant_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PaymentNotification_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELiX64CxWPD/48dXiYRlSp1YbMcFXJrvoztl6MwEHfE4x3dO+Z5a47BEMsuM+07xzw==");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_MerchantId",
                table: "Payment",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentDestinationId",
                table: "Payment",
                column: "PaymentDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentNotification_MerchantId",
                table: "PaymentNotification",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentNotification_PaymentId",
                table: "PaymentNotification",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSignature_PaymentId",
                table: "PaymentSignature",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransaction_PaymentId",
                table: "PaymentTransaction",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Merchant_MerchantId",
                table: "Payment",
                column: "MerchantId",
                principalTable: "Merchant",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentDestination_PaymentDestinationId",
                table: "Payment",
                column: "PaymentDestinationId",
                principalTable: "PaymentDestination",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Merchant_MerchantId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_PaymentDestination_PaymentDestinationId",
                table: "Payment");

            migrationBuilder.DropTable(
                name: "PaymentDestination");

            migrationBuilder.DropTable(
                name: "PaymentNotification");

            migrationBuilder.DropTable(
                name: "PaymentSignature");

            migrationBuilder.DropTable(
                name: "PaymentTransaction");

            migrationBuilder.DropTable(
                name: "Merchant");

            migrationBuilder.DropIndex(
                name: "IX_Payment_MerchantId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_PaymentDestinationId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaidAmount",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentContent",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentCurrency",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentDate",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentDestinationId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentLanguage",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentLastMessage",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "PaymentRefId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "RequiredAmount",
                table: "Payment");

            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "Payment",
                newName: "PaymentMethod");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENHOTWufz9WsKH9/ewIIl0shJmKMFpJQO23XrvfIdZEzUrNmEyt9gCykFKwIniW5Mw==");
        }
    }
}
