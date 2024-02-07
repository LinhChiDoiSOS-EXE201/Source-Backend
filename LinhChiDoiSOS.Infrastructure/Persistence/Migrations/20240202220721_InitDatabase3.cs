using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBt5UW6kjV+gn0SNALQg+PKLVYaUBM3yJ3uSLz4QMa30E/O/DlqUbMtc9ttVieCMQg==");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("2b729efa-3446-405b-9dc7-059a4c451296"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5165), false, null, null, "Kỹ năng sinh tồn" },
                    { new Guid("3a477216-d412-43ca-b05f-653bc84f6609"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5161), false, null, null, "Kiến thức sơ cấp cứu" }
                });

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"), new Guid("2b729efa-3446-405b-9dc7-059a4c451296"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5251), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2F5cachphattinhieucaucuu.png?alt=media&token=6b75b201-d177-47f9-8741-58c52cfcf656", false, null, null, "5 cách phát ra tín hiệu cầu cứu hiệu quả" },
                    { new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"), new Guid("3a477216-d412-43ca-b05f-653bc84f6609"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5184), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fnguyentacantoan.png?alt=media&token=d453d651-2618-4ccc-abc4-44a7d26168e8", false, null, null, "Nguyên tắc an toàn trong sơ cứu" },
                    { new Guid("481abb77-ebd3-47b0-9e9f-718368076074"), new Guid("3a477216-d412-43ca-b05f-653bc84f6609"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5201), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2FCPRhoisinhcapcuu.png?alt=media&token=169fb2c8-5ac3-4926-96f8-13d26c28c78c", false, null, null, "CPR - Hồi sinh tim phổi cơ bản" },
                    { new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"), new Guid("3a477216-d412-43ca-b05f-653bc84f6609"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5198), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fvanchuyennguoibenhantoan.png?alt=media&token=b4aa4bda-dd25-4707-874b-205fc092dccd", false, null, null, "Vận chuyển người bệnh an toàn" },
                    { new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"), new Guid("3a477216-d412-43ca-b05f-653bc84f6609"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5237), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2FsocuuthaotacHeimlich.png?alt=media&token=c2cd2541-914e-4e35-91e4-6b96274060b5", false, null, null, "Hướng dẫn sơ cứu cho thao tác Heimlich" },
                    { new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"), new Guid("2b729efa-3446-405b-9dc7-059a4c451296"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5248), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2Fxacdinhphuonghuongbanglacay.png?alt=media&token=03ac5e6c-1922-49af-ab29-d0c2b5a70e5b", false, null, null, "Xác định phương hướng bằng lá cây" },
                    { new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"), new Guid("2b729efa-3446-405b-9dc7-059a4c451296"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5245), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2Fthatnutdaycoban.png?alt=media&token=434cd218-d2ee-4e15-823c-fe9158f7eecf", false, null, null, "10 cách thắt nút dây cơ bản" },
                    { new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"), new Guid("2b729efa-3446-405b-9dc7-059a4c451296"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5241), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/KyNangSinhTon%2Ftaoluatunhungvatdungcoban.png?alt=media&token=6311c2ef-acb7-4efd-bfc4-9becb3464503", false, null, null, "Tạo lửa từ những vật dụng cơ bản" },
                    { new Guid("f3db0b18-003a-4046-873b-264d3498360c"), new Guid("3a477216-d412-43ca-b05f-653bc84f6609"), null, new DateTime(2024, 2, 3, 5, 7, 20, 661, DateTimeKind.Local).AddTicks(5190), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Ftuthenamantoan.png?alt=media&token=b84b752c-668f-4eed-8a23-c2743e97fb1f", false, null, null, "Tư thế nằm nghiêng nan toàn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELIH15j8Knjg7KgUg3oHnQFi+2gg0D3JNkG9wQKr2EGGprhW5/C0J1fkx/dO5sJFSw==");

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 2, 3, 3, 47, 0, 663, DateTimeKind.Local).AddTicks(4468));
        }
    }
}
