using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase213 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELrMDqgWzzUBTwDumdsk/YSMrpQKuBqfIYIzXg/HH83+/lC3VeqWPSRIkeSe0vLxpQ==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.InsertData(
                table: "CategoryKeyword",
                columns: new[] { "Id", "CreateBy", "Created", "Description", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3463), "", false, null, null, "Tim" },
                    { new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3457), "", false, null, null, "Miệng" },
                    { new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3461), "", false, null, null, "Mũi" },
                    { new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3455), "", false, null, null, "Mắt" },
                    { new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3459), "", false, null, null, "Xương khớp" },
                    { new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3451), "", false, null, null, "Đầu" }
                });

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.InsertData(
                table: "Keyword",
                columns: new[] { "Id", "CategoryKeywordId", "CreateBy", "Created", "Description", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"), new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3645), "", false, null, null, "Điểm gồ lên trên da" },
                    { new Guid("05eb9523-cbad-4abb-97df-00159d409a78"), new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3640), "", false, null, null, "Có tiếng lạo xạo" },
                    { new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"), new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3630), "", false, null, null, "Xưng tấy ngoài da" },
                    { new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"), new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3495), "", false, null, null, "Đau nữa đầu sau" },
                    { new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3615), "", false, null, null, "Răng va vào nhau" },
                    { new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"), new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3657), "", false, null, null, "Chảy máu cam" },
                    { new Guid("32475e06-c246-437b-9298-4523809622c2"), new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3642), "", false, null, null, "Bầm tím" },
                    { new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"), new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3505), "", false, null, null, "Chóng mặt" },
                    { new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"), new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3511), "", false, null, null, "Đỏ mắt" },
                    { new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"), new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3635), "", false, null, null, "Đau nhói" },
                    { new Guid("4b467404-7405-430b-b458-8aacac949a5b"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3612), "", false, null, null, "Khó nói chuyện" },
                    { new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"), new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3662), "", false, null, null, "Đập nhanh" },
                    { new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"), new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3490), "", false, null, null, "Đau nữa đầu trước" },
                    { new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"), new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3647), "", false, null, null, "Khó thở" },
                    { new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"), new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3653), "", false, null, null, "Sổ mũi" },
                    { new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"), new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3650), "", false, null, null, "Nghẹt mũi" },
                    { new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"), new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3665), "", false, null, null, "Đau nhói nhẹ" },
                    { new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"), new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3516), "", false, null, null, "Chảy nước mắt" },
                    { new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3519), "", false, null, null, "Mất vị giác" },
                    { new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"), new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3667), "", false, null, null, "Đau nhói thường xuyên" },
                    { new Guid("9bc401f4-517b-4765-885f-1c480893f229"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3625), "", false, null, null, "Ho khan" },
                    { new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"), new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3670), "", false, null, null, "Cảm giác chèn ép" },
                    { new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3618), "", false, null, null, "Chảy máu chân răng" },
                    { new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"), new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3500), "", false, null, null, "Tê trán" },
                    { new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"), new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3513), "", false, null, null, "Đau mắt" },
                    { new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3609), "", false, null, null, "Tê liệt một phần môi" },
                    { new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"), new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3659), "", false, null, null, "Nước mũi có mùi hôi" },
                    { new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"), new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3637), "", false, null, null, "Không thể cử động" },
                    { new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3622), "", false, null, null, "Nóng rang cổ họng" },
                    { new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3628), "", false, null, null, "Buồn nôn" },
                    { new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"), new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3508), "", false, null, null, "Mắt lờ đờ" },
                    { new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"), new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3502), "", false, null, null, "Ù tai" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFd30xLPDiVS3lQAqtZ8Cbb/wfxKUQmmdQeHUdBU4Cj8blZXyMy6pU+C/MVc/cLNUw==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 2, 19, 14, 35, 1, 25, DateTimeKind.Local).AddTicks(5700));
        }
    }
}
