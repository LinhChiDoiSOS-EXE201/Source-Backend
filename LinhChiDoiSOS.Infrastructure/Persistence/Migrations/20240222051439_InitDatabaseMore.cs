using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabaseMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuanDoan_Keyword_KeywordId",
                table: "ChuanDoan");

            migrationBuilder.DropIndex(
                name: "IX_ChuanDoan_KeywordId",
                table: "ChuanDoan");

            migrationBuilder.DropColumn(
                name: "KeywordId",
                table: "ChuanDoan");

            migrationBuilder.CreateTable(
                name: "ChuanDoan_Keyword",
                columns: table => new
                {
                    ChuanDoanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KeywordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuanDoan_Keyword", x => new { x.ChuanDoanId, x.KeywordId });
                    table.ForeignKey(
                        name: "FK_ChuanDoan_Keyword_ChuanDoan_ChuanDoanId",
                        column: x => x.ChuanDoanId,
                        principalTable: "ChuanDoan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChuanDoan_Keyword_Keyword_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keyword",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA7yVpuOLXxjPR62qakXRZVyRGsom0IKLOqbld6+VKQH3lwlaKbcjPuvsEBcLuSZ/A==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.InsertData(
                table: "CategoryKeyword",
                columns: new[] { "Id", "CreateBy", "Created", "Description", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(493), "", false, null, null, "Trực tràng" },
                    { new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(491), "", false, null, null, "Bụng" },
                    { new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(489), "", false, null, null, "Cơ thể" }
                });

            migrationBuilder.InsertData(
                table: "ChuanDoan",
                columns: new[] { "Id", "CreateBy", "Created", "Description", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(819), "Dịch bệnh viêm đường hô hấp cấp do chủng Coronavirus mới (Covid-19) vẫn đang diễn biến rất phức tạp, nó đã lan rộng ra nhiều quốc gia và vùng lãnh thổ khác ngoài Trung Quốc.", false, null, null, "Covid-19" },
                    { new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(805), "Viêm amidan là bệnh phổ biến gặp ở mọi lứa tuổi trong cộng đồng, gây ra những triệu chứng đau rát họng, khó nuốt. Nếu không điều trị sớm có thể dẫn đến những ảnh hưởng sức khỏe nghiêm trọng hơn.", false, null, null, "Viêm Amidan" },
                    { new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(813), "Thiếu máu não là tình trạng giảm tuần hoàn máu lên não, dẫn tới giảm cung cấp oxy và dưỡng chất cần thiết cho các hoạt động của não bộ ảnh hưởng tới cầu trúc và chức năng của một phần hoặc nhiều phần trên não.", false, null, null, "Thiếu máu não" },
                    { new Guid("17617323-50a0-492c-a220-84ea0235735f"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(877), "Đau ruột thừa là dấu hiệu cảnh báo ruột thừa đang có vấn đề, thường gặp nhất là viêm ruột thừa, ruột thừa có thể bị vỡ, nguy hiểm đến tính mạng.", false, null, null, "Đau ruột thừa" },
                    { new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(827), "Thiếu máu là tình trạng lượng huyết sắc tốc và số lượng hồng cầu có trong máu ngoại vi bị giảm đi, kết quả là thiếu lượng oxy đến các mô của các tế bào trong cơ thể.\r\n", false, null, null, "Thiếu máu" },
                    { new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(882), "Huyết áp thấp sẽ nguy hiểm đến tính mạng nếu như không được phòng tránh và chữa trị kịp thời.", false, null, null, "Huyết áp thấp" },
                    { new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(802), "Đau bụng kinh (hay thống kinh) là triệu chứng rất phổ biến, liên quan đến chu kỳ kinh nguyệt của nữ giới.", false, null, null, "Đau bụng kinh" },
                    { new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(824), "Người bị đột quỵ cần được cấp cứu ngay lập tức, thời gian kéo dài càng lâu, số lượng tế bào não chết càng nhiều sẽ ảnh hưởng lớn tới khả năng vận động và tư duy của cơ thể, thậm chí là tử vong.", false, null, null, "Đột quỵ" },
                    { new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(887), "Bệnh viêm kết mạc là bệnh thường gặp, do nhiều nguyên nhân khác nhau gây ra. Bệnh có thể tự khỏi mà không cần điều trị. ", false, null, null, "Viêm kết mạc" },
                    { new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(867), "Rối loạn nhịp tim là tình trạng xảy ra khi các xung điện điều khiển nhịp tim hoạt động bất thường, khiến tim đập quá nhanh, quá chậm hoặc không đều. ", false, null, null, "Rối loạn nhịp tim" },
                    { new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(808), "Viêm tai giữa là một nhóm các bệnh ở tai giữa, là sự tổn thương và viêm nhiễm xuất hiện trong tai giữa do các loại vi khuẩn sinh sôi và phát triển trong tai hoặc bị tác động từ các yếu tố bên ngoài môi trường.", false, null, null, "Viêm tai giữa" },
                    { new Guid("689782fb-f292-47fb-9e78-990e92a0e390"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(800), "Táo bón là tình trạng khó đi đại tiện, phân khô cứng, buồn đi đại tiện mà không đi được phải rặn mạnh phân khó thoát ra, thời gian đi lâu hoặc nhiều ngày mới đi một lần.", false, null, null, "Táo bón" },
                    { new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(890), "Gãy xương đòn là gãy xương nằm dài nằm ngay dưới da vùng vai, nối giữa xương ức và hệ thống đai vai – cánh tay, có tác dụng như một thanh chống, giằng giữa thân mình và khớp vai.", false, null, null, "Gãy xương đòn" },
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(796), "Cảm lạnh là một trong những căn bệnh về đường hô hấp thường gặp phải ở trẻ em và người lớn", false, null, null, "Cảm lạnh" },
                    { new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(798), "Tiêu chảy là tình trạng mà cơ thể loại bỏ phân đi lỏng hoặc phân nước từ 3 lần/ngày.", false, null, null, "Tiêu chảy" },
                    { new Guid("ade4f561-1316-489d-b752-dc042dd5b700"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(874), "Bệnh trào ngược dạ dày thực quản có thể gây kích ứng niêm mạc thực quản của người bệnh. ", false, null, null, "Trào ngược axit dạ dày thực quản" },
                    { new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(816), "Cao huyết áp (hay tăng huyết áp) là một bệnh lý mãn tính khi áp lực của máu tác động lên thành động mạch tăng cao.", false, null, null, "Huyết áp cao" },
                    { new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(879), "Một số người bị rối loạn tiền đình có thể chịu ảnh hưởng nghiêm trọng của bệnh đến cuộc sống hằng ngày cũng như trong học tập.", false, null, null, "Rối loạn tiền đình" },
                    { new Guid("d343e947-dbba-4631-9796-9364369efac4"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(870), "Chèn ép tim cấp là một trường hợp cấp cứu, cần được chẩn đoán và xử lý nhanh chóng.", false, null, null, "Chèn ép tim cấp" },
                    { new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(885), "Rối loạn thần kinh thực vật là sự mất cân bằng của hai hệ thống thần kinh giao cảm và phó giao cảm. Bệnh gây đau khiến bệnh nhân gặp phải những hạn chế trong cuộc sống. ", false, null, null, "Rối loại thần kinh thực vật" },
                    { new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(792), "Viêm xoang là tình trạng viêm nhiễm các túi khí gần mũi và mắt, thường gây đau đầu và áp lực ở vùng mặt. Điều trị bao gồm thuốc và biện pháp giảm triệu chứng.", false, null, null, "Viêm xoang" },
                    { new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(821), "Bệnh nha chu là một bệnh nhiễm trùng nướu nghiêm trọng làm tổn thương mô mềm và phá hủy xương xung quanh răng.", false, null, null, "Viêm nha chu" }
                });

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.InsertData(
                table: "Keyword",
                columns: new[] { "Id", "CategoryKeywordId", "CreateBy", "Created", "Description", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("26d69d6f-f485-46b3-bd62-1b80b2bfc7d7"), new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(525), "", false, null, null, "Buồn nôn" },
                    { new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"), new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(672), "", false, null, null, "Đau họng" },
                    { new Guid("61105e2b-b22e-4eb2-897f-941818211986"), new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(534), "", false, null, null, "Đau đầu" }
                });

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 12, 14, 38, 967, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.InsertData(
                table: "ChuanDoan_Keyword",
                columns: new[] { "ChuanDoanId", "KeywordId" },
                values: new object[,]
                {
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68") },
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), new Guid("61105e2b-b22e-4eb2-897f-941818211986") },
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995") },
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4") },
                    { new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"), new Guid("26d69d6f-f485-46b3-bd62-1b80b2bfc7d7") },
                    { new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"), new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b") },
                    { new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"), new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d") },
                    { new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"), new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4") },
                    { new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"), new Guid("9bc401f4-517b-4765-885f-1c480893f229") }
                });

            migrationBuilder.InsertData(
                table: "Keyword",
                columns: new[] { "Id", "CategoryKeywordId", "CreateBy", "Created", "Description", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"), new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(728), "", false, null, null, "Đầy hơi" },
                    { new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"), new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(725), "", false, null, null, "Chuột rút" },
                    { new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"), new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(720), "", false, null, null, "Mệt mỏi" },
                    { new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"), new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(730), "", false, null, null, "Đau bụng" },
                    { new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"), new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(733), "", false, null, null, "Đại tiện ra máu" },
                    { new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"), new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(723), "", false, null, null, "Sốt" },
                    { new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"), new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"), null, new DateTime(2024, 2, 22, 12, 14, 38, 968, DateTimeKind.Local).AddTicks(737), "", false, null, null, "Khó đại tiện" }
                });

            migrationBuilder.InsertData(
                table: "ChuanDoan_Keyword",
                columns: new[] { "ChuanDoanId", "KeywordId" },
                values: new object[,]
                {
                    { new Guid("689782fb-f292-47fb-9e78-990e92a0e390"), new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b") },
                    { new Guid("689782fb-f292-47fb-9e78-990e92a0e390"), new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0") },
                    { new Guid("689782fb-f292-47fb-9e78-990e92a0e390"), new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1") },
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309") },
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7") },
                    { new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"), new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665") },
                    { new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"), new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309") },
                    { new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"), new Guid("41455e11-ec85-4698-9a2d-f57c64a45762") },
                    { new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"), new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b") },
                    { new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"), new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChuanDoan_Keyword_KeywordId",
                table: "ChuanDoan_Keyword",
                column: "KeywordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChuanDoan_Keyword");

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("17617323-50a0-492c-a220-84ea0235735f"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("689782fb-f292-47fb-9e78-990e92a0e390"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("ade4f561-1316-489d-b752-dc042dd5b700"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("d343e947-dbba-4631-9796-9364369efac4"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"));

            migrationBuilder.DeleteData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("26d69d6f-f485-46b3-bd62-1b80b2bfc7d7"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("61105e2b-b22e-4eb2-897f-941818211986"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"));

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"));

            migrationBuilder.DeleteData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"));

            migrationBuilder.AddColumn<Guid>(
                name: "KeywordId",
                table: "ChuanDoan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3451));

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
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 2, 21, 22, 45, 24, 757, DateTimeKind.Local).AddTicks(3502));

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

            migrationBuilder.CreateIndex(
                name: "IX_ChuanDoan_KeywordId",
                table: "ChuanDoan",
                column: "KeywordId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuanDoan_Keyword_KeywordId",
                table: "ChuanDoan",
                column: "KeywordId",
                principalTable: "Keyword",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
