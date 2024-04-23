using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("003de35b-1d02-42f8-b129-de6d48d15ba1"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("41daf175-b7e1-46ae-9257-3ea027fd7a95"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("541e6a6e-2e89-4973-b6e3-9b643ab60c69"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("602121ed-dc56-4095-94fd-8e329faedec6"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("659f4a16-cdc6-4e53-b078-85db873031e7"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("6baa8673-683e-46d6-832c-2bcbb0921546"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("9ea523a3-40bc-4dcc-aff7-a470ed73376f"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("d9c3179b-5c53-410f-9d06-dab05f300c7b"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("dc04ad98-67bb-44f5-9d44-52118cea6b74"));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGd0NJkRq1BamHlahLSAA2WvCfOj83z8PI6BFNrhFa7/TknI+d5g90WJkskcec/pYg==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("17617323-50a0-492c-a220-84ea0235735f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("689782fb-f292-47fb-9e78-990e92a0e390"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("ade4f561-1316-489d-b752-dc042dd5b700"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("d343e947-dbba-4631-9796-9364369efac4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.InsertData(
                table: "CourseDetail",
                columns: new[] { "Id", "Conlusion", "Content", "CourseId", "CreateBy", "Created", "ImageUrl", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("011b87b3-097b-4328-b511-87f70eb12fb2"), null, "    <div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            Bí Quyết Xác Định Phương Hướng Bằng Lá Cây: Kỹ Năng Sinh Tồn Cơ Bản\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong các tình huống khẩn cấp hoặc khi bị lạc trong thiên nhiên, việc biết cách xác định phương hướng có thể\r\n            là yếu tố quyết định giữa sự sống và cái chết. Mặc dù hiện đại có nhiều công nghệ giúp xác định hướng, nhưng\r\n            việc sử dụng các phương tiện tự nhiên như lá cây vẫn là một kỹ năng cơ bản mà bất kỳ ai cũng nên biết. Trong\r\n            bài viết này, chúng ta sẽ khám phá cách sử dụng lá cây để xác định phương hướng.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://bizweb.dktcdn.net/100/032/885/files/cac-ky-nang-sinh-ton-trong-rung-ban-nen-biet.jpg?v=1664768241728\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Lá Cây Như Một Dụng Cụ Xác Định Phương Hướng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá cây có thể được sử dụng để xác định hướng chính xác bằng cách nhìn vào cách mà các lá hình dạng và\r\n                màu sắc của chúng thay đổi dựa trên hướng mặt trời.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Hướng Dựa Trên Sự Chiếu Sáng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá Cây Láng: Lá cây sẽ láng hơn ở phía nam so với phía bắc vì mặt trời chiếu sáng trực tiếp vào phía\r\n                nam. Kích Thước Của Bóng Dáng: Khi mặt trời ở trên đỉnh, bóng của cây sẽ nằm ở phía dưới cây về phía\r\n                phía đông. Khi mặt trời ở phía tây, bóng của cây sẽ nằm ở phía dưới cây về phía tây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Cây Cây Đồng Thời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Tập Trung: Các cây sẽ tập trung nhiều ở phía bắc vì phía nam thường có ít ánh sáng mặt trời\r\n                hơn.\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Dày Đặc: Cây sẽ dày đặc hơn ở phía nam do nhận được nhiều ánh sáng mặt trời hơn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">4. Sự Thực Hành</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Thực hành thường xuyên và thử nghiệm với lá cây để làm quen với cách chúng phản ánh ánh sáng và hướng\r\n                của mặt trời trong các điều kiện khác nhau.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách sử dụng lá cây để xác định phương hướng là một kỹ năng cơ bản và quan trọng trong việc sinh\r\n                tồn trong môi trường tự nhiên. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến\r\n                thức cần thiết để thực hiện điều này một cách hiệu quả. Hãy thực hành và trở thành một bậc thầy trong\r\n                việc xác định hướng bằng lá cây!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2034), null, false, null, null, null },
                    { new Guid("16368a4d-e82b-44aa-a137-48ce4170796c"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách Thắt Nút Dây Cơ Bản Mà Bạn Nên Biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Thắt nút là một trong những kỹ năng cơ bản mà ai cũng nên biết, không chỉ trong các hoạt động dã ngoại mà\r\n            còn trong cuộc sống hàng ngày. Từ việc thắt dây giày đến thắt dây dẹt trên thùng đồ, việc biết cách thắt nút\r\n            một cách đúng đắn có thể giúp bạn giữ dây chặt chẽ và an toàn. Trong bài viết này, chúng ta sẽ khám phá 10\r\n            cách thắt nút dây cơ bản mà bạn nên biết.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://chuyendaychi.com/wp-content/uploads/2018/05/n%C3%BAt-th%E1%BA%AFt-d%C3%A2y-th%E1%BA%A3-di%E1%BB%81u.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Nút Dây Dẹt (Overhand Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây dẹt là một trong những nút đơn giản nhất và được sử dụng phổ biến trong cuộc sống hàng ngày. Đây\r\n                là cách thắt nút cơ bản nhất để ngăn dây khỏi tự lỏng ra.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Nút Dây Buộc (Square Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc là một trong những nút được sử dụng rộng rãi để nối hai đoạn dây lại với nhau một cách chắc\r\n                chắn và an toàn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Nút Dây Chặn (Slip Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây chặn là một loại nút có thể điều chỉnh kích thước và được sử dụng để buộc dây một cách nhanh\r\n                chóng và dễ dàng.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Nút Dây Leo Cây (Clove Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo cây là một nút linh hoạt được sử dụng để buộc dây vào một vật thể tròn như cây hoặc ống.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Nút Dây Buông (Bowline Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buông là một trong những nút an toàn nhất để tạo ra một lỗ hoặc vòng không bao giờ tự động co\r\n                lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                6. Nút Dây Buộc Gói (Package Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc gói là một loại nút được sử dụng để buộc chặt các gói hàng hoặc túi.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                7. Nút Dây Buộc Dính (Sheet Bend)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc dính là một cách tốt để nối hai đoạn dây có đường kính khác nhau lại với nhau một cách chắc\r\n                chắn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                8. Nút Dây Leo Núi (Figure Eight Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo núi là một loại nút được sử dụng rộng rãi trong leo núi và leo dã ngoại vì nó giữ dây chắc\r\n                chắn và không bao giờ tự động co lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                9. Nút Dây Buộc Thuyền (Anchor Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc thuyền là một nút đơn giản được sử dụng để buộc dây vào một đinh, cột hoặc vật thể tương\r\n                tự.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                10. Nút Dây Đồng Đều (Trucker's Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây đồng đều là một cách tốt để tạo ra một vòng đeo chắc chắn và được sử dụng rộng rãi trong việc\r\n                buộc chặt và cố định hàng hoặc dụng cụ.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách thắt nút là một kỹ năng quan trọng và hữu ích trong mọi tình huống. Hy vọng rằng bài viết này\r\n                đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện các loại nút cơ bản một cách\r\n                an toàn và hiệu quả. Hãy thực hành thường xuyên để trở thành một chuyên gia thực sự trong việc thắt nút!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2029), null, false, null, null, null },
                    { new Guid("28f0389d-c265-4cde-8c22-31307f7f48f3"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nSơ Cứu Cho Thao Tác Heimlich: Biết Cách Cứu Mạng Trong Trường Hợp Hóc Thức Ăn\r\n</h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong tình huống khẩn cấp khi một người đang bị hóc thức ăn và không thể nói hoặc thở, thao tác Heimlich là một kỹ năng cứu mạng quan trọng. Trong bài viết này, chúng ta sẽ tìm hiểu cách thực hiện thao tác Heimlich một cách đúng đắn để cứu mạng cho người đang bị hóc.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://www.topontiki.gr/wp-content/uploads/2023/08/Untitled-design-2023-08-14T190744.334.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\"> \r\nTrước tiên, hãy đảm bảo rằng người đó thực sự đang bị hóc thức ăn và không thể nói hoặc thở. Nếu họ vẫn có thể nói hoặc ho thở, họ có thể tự giải quyết vấn đề và bạn chỉ cần đề xuất họ làm theo.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Thực Hiện Thao Tác Heimlich\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đứng phía sau: Đứng phía sau người bị hóc, đặt một chân giữa chân họ để tạo sự ổn định.        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Bám vào phía sau: Đặt một bàn tay lớn vào phía trên của hốc ngực của họ, đặt còn lại vào phía dưới, trên phần dưới của lồng ngực.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Thực hiện cú đẩy: Đẩy mạnh và nhanh chóng vào trong và lên trên, hướng ra phía trên, nhưng không đặt quá cao lên phần xương sườn.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Lặp lại nếu cần thiết: Lặp lại cú đẩy cho đến khi vật thể bị hóc được thải ra hoặc cho đến khi đội cứu hộ đến.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sự Theo Dõi Và Hỗ Trợ Sau Khi Thực Hiện\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTheo dõi người bị hóc cho đến khi họ hoàn toàn ổn định.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bị hóc mất ý thức hoặc ngừng hô hấp, thực hiện CPR ngay lập tức.\r\n        </p>\r\n       \r\n    </div>\r\n    \r\n   \r\n  \r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n           Thao tác Heimlich là một kỹ năng cứu mạng quan trọng mà mọi người nên biết. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện thao tác Heimlich một cách an toàn và hiệu quả trong trường hợp cần thiết. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi sự thành công trong sơ cứu.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2023), null, false, null, null, null },
                    { new Guid("37ccb483-9a63-4055-9c3c-fbadfa2e0cab"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            5 Cách Phát Ra Tín Hiệu Cầu Cứu Hiệu Quả Trong Tình Huống Khẩn Cấp\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, khả năng phát ra tín hiệu cầu cứu có thể là yếu tố quyết định giữa sự sống và\r\n            cái chết. Tuy nhiên, không phải ai cũng biết cách phát ra tín hiệu cầu cứu một cách hiệu quả. Trong bài viết\r\n            này, chúng ta sẽ khám phá 5 cách phát ra tín hiệu cầu cứu mà bạn nên biết để có thể thu hút sự chú ý và giúp\r\n            đỡ trong một tình huống khẩn cấp.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://e.khoahoc.tv/photos/image/2015/07/01/SOS_2.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">1. Tiếng Hét Lớn</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách phổ biến nhất để phát ra tín hiệu cầu cứu là hét lớn. Hãy hét càng to càng tốt để\r\n                thu hút sự chú ý của người xung quanh và gửi đi tín hiệu rằng bạn đang gặp vấn đề và cần sự giúp đỡ.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Còi Cứu Hộ\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Mang theo một còi cứu hộ là một ý tưởng tốt để có thể phát ra tín hiệu cầu cứu một cách nhanh chóng và\r\n                dễ dàng. Khi gặp phải tình huống khẩn cấp, bạn chỉ cần thổi vào còi một cách mạnh mẽ để thu hút sự chú ý\r\n                của người xung quanh.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Đèn Pin\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Trong tình huống mà việc gọi cầu cứu bằng tiếng không hiệu quả, việc sử dụng đèn pin có thể là một\r\n                phương tiện hiệu quả khác để thu hút sự chú ý của người xung quanh, đặc biệt là vào ban đêm hoặc trong\r\n                điều kiện ánh sáng yếu.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Gương Soi Ánh Sáng Mặt Trời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn bị mắc kẹt và không thể di chuyển, việc sử dụng một chiếc gương nhỏ hoặc vật phản quang để soi\r\n                ánh sáng mặt trời có thể là một cách hiệu quả để phát ra tín hiệu cầu cứu và thu hút sự chú ý của người\r\n                đi ngang qua.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Biểu Tượng Cầu Cứu Quốc Tế\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một biểu tượng cầu cứu quốc tế như biểu tượng SOS, bạn có thể sử dụng nó để tạo ra tín hiệu\r\n                cầu cứu và gửi đi thông điệp rằng bạn đang cần sự giúp đỡ khẩn cấp.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách phát ra tín hiệu cầu cứu là một kỹ năng quan trọng và có thể cứu sống trong một tình huống\r\n                khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để\r\n                thực hiện điều này một cách an toàn và hiệu quả. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi\r\n                sự thành công trong tình huống khẩn cấp.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2037), null, false, null, null, null },
                    { new Guid("395e6f26-7dc0-453f-8112-4bcca87ad0fc"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nCPR - Kỹ Năng Hồi Sinh Tim Phổi Cơ Bản Mà Mọi Người Cần Biết    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong một tình huống khẩn cấp khi người khác đột ngột gặp phải ngừng tim phổi, kỹ năng CPR (Cardiopulmonary Resuscitation) - hồi sinh tim phổi là một kỹ năng quan trọng có thể cứu mạng. Trong bài viết này, chúng ta sẽ tìm hiểu về CPR cơ bản và cách thực hiện nó một cách hiệu quả.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://th.bing.com/th/id/R.3c96bb6b124829db33aa812a1814ee9d?rik=dnxzH5j9nJ0rnw&pid=ImgRaw&r=0\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCPR là gì?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là quá trình cung cấp áp lực hồi sinh tim phổi thông qua việc nén tim và cung cấp hơi thở nhân tạo, nhằm duy trì lưu lượng máu và ôxy đến não và các cơ quan quan trọng khác.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 1: Kiểm Tra An Toàn\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra khu vực xung quanh để đảm bảo an toàn cho bản thân và người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi cấp cứu nếu có sẵn.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 2: Kiểm Tra Tình Trạng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi lên và kiểm tra phản ứng của người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra hơi thở và dấu hiệu sống\r\n        </p>\r\n       \r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 3: Báo Cáo Và Bắt Đầu CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bệnh không hít thở và không có nhịp tim, bắt đầu CPR ngay lập tức.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNén tim: Đặt lòng bàn tay ở giữa ngực, nén tim khoảng 5-6cm sâu với tần suất khoảng 100-120 lần mỗi phút.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nHơi thở nhân tạo: Thực hiện 2 hơi thở nhân tạo với miệng che miệng và mũi người bệnh.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 4: Tiếp Tục CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTiếp tục lặp lại chu trình nén tim và hơi thở cho đến khi cứu thương viên đến hoặc người bệnh hồi phục.\r\n        </p>\r\n    </div>\r\n</div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nLưu Ý Quan Trọng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nThực hiện CPR một cách nhanh chóng và mạnh mẽ, nhưng đồng thời cẩn thận để tránh gây tổn thương.\r\nĐảm bảo bạn đã được đào tạo và tự tin trước khi thực hiện CPR trên người bệnh.\r\n        </p>\r\n    </div>\r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là một kỹ năng quan trọng mà ai cũng nên biết, vì nó có thể là yếu tố quyết định giữa sự sống và cái chết trong một tình huống khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan về CPR và cung cấp thông tin cần thiết để bạn có thể thực hiện nó một cách hiệu quả khi cần thiết. Hãy nhớ, một phút cứu mạng có thể phát huy tác dụng lớn!\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("481abb77-ebd3-47b0-9e9f-718368076074"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2019), null, false, null, null, null },
                    { new Guid("4bd1ac52-7a08-4eba-8ff0-999862699747"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách thắt nút dây cơ bản mà bạn nên biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong những tình huống khẩn cấp, khả năng tạo lửa có thể là yếu tố quyết định giữa sự sống và cái chết. Dù\r\n            bạn đang dã ngoại, mắc kẹt trong rừng hoặc gặp phải tình huống khẩn cấp khác, biết cách tạo lửa từ những vật\r\n            dụng cơ bản có thể cực kỳ hữu ích. Trong bài viết này, chúng ta sẽ khám phá những cách tạo lửa đơn giản mà\r\n            bất kỳ ai cũng có thể thực hiện.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://st.quantrimang.com/photos/image/2016/11/08/tao-lua-650.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Sử dụng đánh lửa\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách đơn giản nhất để tạo lửa là sử dụng đánh lửa hoặc bật lửa di động. Đảm bảo rằng bạn\r\n                luôn giữ một chiếc đánh lửa hoặc bật lửa trong túi hoặc trong hành trang của mình.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Que Diêm\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Que diêm là một phương tiện khác để tạo lửa nhanh chóng và dễ dàng. Hãy đảm bảo rằng bạn luôn mang theo\r\n                một số que diêm trong túi hoặc hành trang của mình.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Các Vật Dụng Tự Nhiên\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn không có đánh lửa hoặc que diêm, bạn vẫn có thể tạo lửa bằng cách sử dụng các vật dụng tự nhiên\r\n                như cây khô, lá khô, vỏ cây, hoặc cành cây sấy khô dưới ánh nắng mặt trời.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Kỹ Thuật Friction\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một kỹ thuật khác để tạo lửa là sử dụng ma sát. Bạn có thể sử dụng hai vật dụng có thể tạo ra ma sát\r\n                mạnh mẽ khi chúng va chạm với nhau như các cành cây, bàn tay, hoặc một miếng vải và một cành cây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Kính Lúp\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một kính lúp, bạn có thể sử dụng nó để tập trung ánh nắng mặt trời vào một điểm nhỏ trên vật\r\n                liệu cháy để tạo nên lửa.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách tạo lửa từ những vật dụng cơ bản có thể là một kỹ năng quan trọng trong mọi tình huống khẩn\r\n                cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực\r\n                hiện điều này một cách an toàn và hiệu quả. Đừng quên, luôn luôn lưu ý đến sự an toàn khi làm việc với\r\n                lửa.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2026), null, false, null, null, null },
                    { new Guid("4d8fe683-e53f-4a84-818e-62a4256c8e1b"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nHướng Dẫn Vận Chuyển Người Bệnh An Toàn Trong Mọi Tình Huống\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Việc vận chuyển người bệnh là một phần quan trọng trong sơ cứu và chăm sóc y tế. Tuy nhiên, nếu không thực hiện đúng cách, nó có thể gây ra thêm tổn thương và biến chứng cho người bệnh. Trong bài viết này, chúng ta sẽ tìm hiểu về cách vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://baoquangbinh.vn/dataimages/202107/original/images704000_cc3.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi vận chuyển bất kỳ người bệnh nào, hãy đánh giá tình hình và quyết định liệu có cần gọi xe cấp cứu hay không. Nếu không có xe cấp cứu, đảm bảo rằng bạn có đủ sự trang bị và kiến thức để vận chuyển một cách an toàn.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Chuẩn Bị Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nĐảm bảo không gian vận chuyển rộng rãi và an toàn.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLoại bỏ các vật dụng nguy hiểm khỏi lối đi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLàm cho không gian thoáng đãng và dễ dàng tiếp cận.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sử Dụng Kỹ Thuật Đúng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng các kỹ thuật vận chuyển như chuyển lên giường, ghế hoặc xe lăn một cách cẩn thận và nhẹ nhàng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn sử dụng tư thế bảo vệ cho cơ thể của người bệnh, đặc biệt là đầu, cổ và cột sống.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng hỗ trợ bổ sung như gối, băng cố định và dây đai an toàn nếu cần thiết.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n4. Giao Tiếp Và Động Viên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn giữ liên lạc với người bệnh và cung cấp sự động viên và an ủi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGiải thích mọi động tác và kế hoạch di chuyển trước khi thực hiện.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n5. Sự Theo Dõi Sau Khi Vận Chuyển\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSau khi đặt người bệnh vào vị trí mới, đảm bảo rằng họ đang cảm thấy thoải mái và không gặp phải bất kỳ vấn đề nào.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra các dấu hiệu và triệu chứng có thể báo hiệu về tình trạng tồn tại hoặc mới.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Việc vận chuyển người bệnh đòi hỏi sự chuẩn bị kỹ lưỡng, kiến thức và kỹ năng. Quan trọng nhất là phải luôn đặt sự an toàn và thoải mái của người bệnh lên hàng đầu. Hy vọng rằng với những hướng dẫn trên, bạn sẽ có thêm niềm tin và kiến thức để vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2017), null, false, null, null, null },
                    { new Guid("8eb2f931-5fdb-43c7-9230-56cb04f10598"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n        Nguyên Tắc An Toàn Trong Sơ Cứu: Bảo Vệ Sức Khỏe Mọi Người\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Sơ cứu là một kỹ năng cơ bản mà mỗi người nên biết, vì nó có thể giữ lại mạng sống cho người khác trong những tình huống khẩn cấp. Tuy nhiên, sự hiểu biết về những nguyên tắc an toàn trong quá trình thực hiện sơ cứu cũng quan trọng không kém. Dưới đây là những nguyên tắc quan trọng cần tuân thủ để đảm bảo an toàn cho cả người cứu thương lẫn người bị nạn.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fsocapcuu.jpg?alt=media&token=8f3138c9-174e-4933-867e-c4ae18095c1f\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            1. Bảo Vệ Bản Thân Đầu Tiên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Khi đối mặt với tình huống sơ cứu, quyết định đầu tiên và quan trọng nhất là bảo vệ chính bạn. Đảm bảo rằng không có nguy hiểm nào tiếp tục tồn tại trước khi tiếp cận người bị nạn. Đeo bảo hộ cá nhân nếu có thể, và luôn đánh giá an toàn cho cả mình và người xung quanh.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Gọi Cấp Cứu Trước Khi Hành Động\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi bắt đầu thực hiện bất kỳ biện pháp sơ cứu nào, việc gọi đến số điện thoại cấp cứu là điều quan trọng. Cung cấp thông tin chi tiết về tình hình và tuân theo hướng dẫn từ bác sĩ điều phối giúp đảm bảo có kế hoạch chăm sóc y tế chính xác và nhanh chóng.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            3. Đánh Giá An Toàn Của Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi tiếp cận nạn nhân, hãy đánh giá môi trường xung quanh để đảm bảo an toàn cho cả người cứu thương và người bị nạn. Loại bỏ các nguy cơ tiềm ẩn như lửa, điện áp cao, hoặc vật dụng gây nguy hiểm.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            4. Động Tác Nhẹ Nhàng và Hiệu Quả\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong quá trình thực hiện sơ cứu, hãy luôn tuân thủ nguyên tắc \"động tác nhẹ nhàng\". Tránh gây thêm tổn thương cho nạn nhân và chỉ thực hiện những biện pháp mà bạn đã được đào tạo. Sự nhẹ nhàng kết hợp với hiệu quả sẽ giúp giảm nguy cơ gặp phải tác động phụ không mong muốn.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            5. Đề Xuất Giúp Đỡ Từ Người Xung Quanh\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, không ngần ngại hỏi xem có ai khác có kỹ năng sơ cứu hay không. Sự hợp tác giữa mọi người có thể tăng khả năng cứu sống và giảm áp lực cho người cứu thương chính.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Nhớ rằng, việc thực hiện sơ cứu không chỉ là về việc cứu sống mà còn là về cách làm đúng để đảm bảo an toàn cho tất cả mọi người liên quan. Hãy hiểu rõ và áp dụng những nguyên tắc an toàn này để sẵn sàng đối mặt với mọi tình huống khẩn cấp một cách hiệu quả và an toàn.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2011), null, false, null, null, null },
                    { new Guid("ed1ecbf3-02ff-4cf7-8ebd-c87fd66a2caf"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n       Tư Thế Nằm Nghiêng An Toàn Trong Sơ Cấp Cứu: Biết Để Bảo Vệ Bản Thân và Người Khác\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Nhắc đến sơ cấp cứu, việc biết cách giữ tư thế nằm nghiêng an toàn có thể là yếu tố quyết định giữa sự cứu chữa thành công và biến chứng nghiêm trọng. Trong bài viết này, chúng ta sẽ tìm hiểu về các tư thế nằm nghiêng cơ bản mà bạn có thể áp dụng trong các trường hợp khẩn cấp.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://suckhoe123.vn/uploads/suc-khoe/2021_05/20200424_172336_448622_nghieng.max-1800x1800.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            Tại sao Tư Thế Nằm Nghiêng Quan Trọng?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một số trường hợp, đặc biệt là khi có nguy cơ nôn mửa hoặc hít phải chất lỏng, máu hoặc cơ hội nằm nghiêng có thể ngăn chặn việc phụt ngược chất lỏng vào đường hô hấp, giữ cho đường thoát khí mở rộng và giảm áp lực lên cổ và phổi.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCách Thực Hiện Tư Thế Nằm Nghiêng\r\n        </p>\r\n    </div>\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Tư Thế Nằm Nghiêng Đơn Giản:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp và kéo một chân về phía trên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một bộ phận dưới đầu để giữ cho đầu của họ nghiêng về một bên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đảm bảo đầu và cổ của họ đều ở vị trí tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Tư Thế Nằm Nghiêng Phức Tạp:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một tấm gối hoặc đối vật cứng dưới người bệnh từ dưới đầu đến dưới đùi của họ.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Kéo một chân của họ về phía trên và đặt gối hoặc chăn dưới chân để giữ cho cơ thể họ nghiêng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Giữ đầu và cổ của họ trong một tư thế tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Lưu Ý Quan Trọng\r\nLuôn Giữ Đầu và Cổ Trong Tư Thế Tự Nhiên: Đảm bảo rằng đầu và cổ của người bệnh luôn được giữ trong một tư thế tự nhiên và không bị ép vào bất kỳ hướng nào khi thực hiện tư thế nằm nghiêng.\r\nTheo Dõi Tình Trạng Của Người Bệnh: Luôn lưu ý đến các biểu hiện của người bệnh và sẵn sàng điều chỉnh tư thế nếu cần thiết.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("f3db0b18-003a-4046-873b-264d3498360c"), null, new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2014), null, false, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("07f89298-3fe2-4f16-a33d-209a7feb9526"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0a4e0c7b-3455-4d10-a25c-d5d78e84efb1"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0c3aa435-c958-4152-a7a6-309bf52337d0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0cff733f-47e0-4656-b356-557d02ef9f9c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0de1b351-990b-49d2-b1d9-aff6f2f6c0e2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e6d3177-7510-4290-8ae7-02c7dcf2bd46"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("116c0f70-7610-4383-9c5f-10cd086f198a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("15f7c3e2-71bf-4c82-95a7-d49ef1b76e99"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("17676ce9-6d78-489b-8803-a651875391e9"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1e9dae67-083c-40a3-9d33-1de20e22c900"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("201cafab-4d18-461e-83db-3f15ad9ba19c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2162f4cd-abe5-4945-ac9c-49c2e12acc88"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("22034197-b916-4c2a-b8b5-cc60ec336b20"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2563e2fa-324f-41a0-b780-7034fb55152b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2803f828-f218-4eae-b560-19b1c4903c96"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2977fa59-3ebe-407c-b804-42c381020f74"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("299b419b-4894-4d0e-820f-e62774aab8c6"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("29ef856c-1ceb-4ce4-8de0-adebd76d8589"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2b581b39-6ff7-465e-b28d-8e8dbdef52aa"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2de49840-07b0-478c-b045-a46e311bfc2d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2e524aca-1a0f-4125-a7c7-da24663d327b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("346a6ce7-fd63-4788-9c8d-72da3a606b20"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3985bbaa-790d-4301-a500-02c0feac422f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3fce95fa-36d0-452f-912f-a66689bcd54f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f3b8ce-43a1-4256-a8ae-9d96ea94f127"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f9158a-50bb-4800-b104-7f43f452b4da"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("41fa54be-cb59-42ad-a6bd-48f705b7bd7a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("45dc3263-0892-40fa-bc5b-2a9cd86be147"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("4787dab5-0205-412a-a0b3-d15f716a25f1"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("479d98e3-0a00-4294-9678-f0e03bd75048"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("53ab9697-804f-4492-93c7-cfcf2c975c2a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("55c613db-7c7d-4c61-aaba-bdfb6ee2222b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("57b75328-ba3b-4c89-af42-f3f98f6460ec"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5e313fda-e478-4f37-9bd8-2310ed956e41"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5f589b73-6307-4ba1-9b6e-a0aea9dbb10a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("616fcfd4-aad3-4881-8fc2-cfbbfa2077dd"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("632ba757-0dc2-4a89-8462-285041471db2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("6e3bd858-0dad-4cfb-ad3c-18ea0a51ba59"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7179302f-70cf-482c-9027-f94ed74ff7a1"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("773c3118-1127-4c00-b8ae-4acf2fff8e84"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("79509a95-2ce1-496e-82f6-98b31940c359"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7978618a-d7be-4975-8db9-648a435925ce"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("80ca4742-e86a-4b7e-b1de-7d71184ee956"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("81725d34-8224-438c-995e-2a02006295fb"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("886cee20-5a0a-4f87-a059-aa0759c065d4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89d12998-fd7a-4858-8f65-6ca330469d80"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8c19130d-a281-47f4-9753-697267f4ecbd"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8d5d44f6-39a9-4483-b121-ba884210360a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("905a8ca1-92ef-445f-a4aa-1838d653af5b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("910cae89-7155-499f-8b69-0071b959fe59"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9420bbd8-3702-438b-9470-9fa5fff9a0ba"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("94c10218-2f11-4892-a64d-2c729f254536"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9951c3aa-3245-4a3b-ae23-26339b08ece0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9ae701b5-c513-4d0b-a2b1-eef8ef995e18"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9e6064b5-db1e-456f-b113-0034f1a6fdd4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a4dca733-6788-469b-9980-6da0759e8089"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a5f66dd3-7f64-4f32-90b3-19a8615380ab"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a6205571-be0e-4b95-9ffd-a5addedb4bd7"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a82eaf8a-5cb2-4815-9394-59110a2a3699"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa158c9c-5a68-4059-b1ae-e4085adcd51f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa97700c-2471-4845-87c7-4d5d19e4e835"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa9d9c94-ce3f-42a2-acff-84f85608748c"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ac02f0ed-e9be-4cfa-99c8-2aa060954bd9"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aed8237a-800e-47da-8aa7-b8935b0d4401"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("af068e17-d32c-43e2-9f3a-af0602ff6731"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b02698b9-8560-4c1b-967b-8c4cf7c68c03"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b1b7706a-3faa-4943-a8b2-6d3854a47ec4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8a7ec77-865b-4864-b52c-e0951b48e322"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8da47d7-edd8-484a-b06d-691a07b2739f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b9ea8984-a752-4ac4-8bf2-e30a90e497d0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ba4b51a1-460c-4a32-801e-1c65b8d624b5"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc199684-de95-437c-8d1a-8c1e8f6cc1d2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc5db5fe-b982-44e6-a591-b2596ccd5522"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bf2ea4b1-05db-4175-96ca-87008a609fe9"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("c88d5f35-4c11-42a4-b355-d0052b08687e"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd8eb190-a455-4f5f-bc21-8900c829ad46"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cec9cab3-beaf-440e-88ef-91452dc4b077"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ceca8b5d-a8c6-457f-a681-eebcfacfe9f4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d3a98af4-5c3e-4b87-9938-788264ff9a36"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d53d9426-a3d9-401c-b7b3-7af4974a6572"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d8f9cc58-73bb-49cb-b8a5-c9693ff067de"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("dab66311-12f2-44ce-8719-83d67e21bfdd"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("de66382b-5819-4d2c-b0af-37e7eaf682b5"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("df288229-2da4-4832-9913-70c1a7e05e8f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e091b4cd-98f8-4fe3-97ba-9c016c7822e2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e57daddb-f9b7-483b-b4ab-153957577e7f"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e66354a9-760d-4826-a002-04a81ba09c8d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e848a319-5e9a-4dba-975d-8c1e5247a97a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eea55b8b-fa03-4ecb-819a-ca9a6f9d43ef"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eebeef97-4736-476c-99af-dfd4ed9f5255"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("efe5f9c2-9615-41b1-a4db-b229dea17bef"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f160154b-b34a-49f6-89a8-0f80311d0641"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f4f0a748-18a6-4546-b4d0-62ac473c7394"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("fbf0061b-5f88-45f1-8546-ca2e9d5ed35d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("01ea28b2-56ff-44e8-883a-ef8890bd426d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("090a2b95-7b45-4600-ad80-dd2853cc9685"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0cb0d678-9454-4391-bd9e-2b536a50f1f7"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("61105e2b-b22e-4eb2-897f-941818211986"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c57b22b-c472-419c-ad81-ee87410c36de"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("831c6f2e-7c32-4ae6-8af6-fdb3897c612b"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("8ef3e270-6c5a-4393-9060-de98e98e6e84"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("a7247c61-4ce6-478c-8c6f-56df1c72fe1d"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("bfe028fa-949f-44c8-95c9-fbb4537114c9"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c55d01ce-f82b-4ef4-b9b2-42452d718e50"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 4, 23, 20, 53, 2, 62, DateTimeKind.Local).AddTicks(1926));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("011b87b3-097b-4328-b511-87f70eb12fb2"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("16368a4d-e82b-44aa-a137-48ce4170796c"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("28f0389d-c265-4cde-8c22-31307f7f48f3"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("37ccb483-9a63-4055-9c3c-fbadfa2e0cab"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("395e6f26-7dc0-453f-8112-4bcca87ad0fc"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("4bd1ac52-7a08-4eba-8ff0-999862699747"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("4d8fe683-e53f-4a84-818e-62a4256c8e1b"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("8eb2f931-5fdb-43c7-9230-56cb04f10598"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("ed1ecbf3-02ff-4cf7-8ebd-c87fd66a2caf"));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEARH5ZJYCS/E02JhBiD/S6G6LCIyXIu7Jcj8ZnsIpPRuAQM1lMmhpmWPoTHbKGFUvw==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("17617323-50a0-492c-a220-84ea0235735f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("689782fb-f292-47fb-9e78-990e92a0e390"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("ade4f561-1316-489d-b752-dc042dd5b700"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("d343e947-dbba-4631-9796-9364369efac4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.InsertData(
                table: "CourseDetail",
                columns: new[] { "Id", "Conlusion", "Content", "CourseId", "CreateBy", "Created", "ImageUrl", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("003de35b-1d02-42f8-b129-de6d48d15ba1"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n        Nguyên Tắc An Toàn Trong Sơ Cứu: Bảo Vệ Sức Khỏe Mọi Người\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Sơ cứu là một kỹ năng cơ bản mà mỗi người nên biết, vì nó có thể giữ lại mạng sống cho người khác trong những tình huống khẩn cấp. Tuy nhiên, sự hiểu biết về những nguyên tắc an toàn trong quá trình thực hiện sơ cứu cũng quan trọng không kém. Dưới đây là những nguyên tắc quan trọng cần tuân thủ để đảm bảo an toàn cho cả người cứu thương lẫn người bị nạn.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fsocapcuu.jpg?alt=media&token=8f3138c9-174e-4933-867e-c4ae18095c1f\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            1. Bảo Vệ Bản Thân Đầu Tiên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Khi đối mặt với tình huống sơ cứu, quyết định đầu tiên và quan trọng nhất là bảo vệ chính bạn. Đảm bảo rằng không có nguy hiểm nào tiếp tục tồn tại trước khi tiếp cận người bị nạn. Đeo bảo hộ cá nhân nếu có thể, và luôn đánh giá an toàn cho cả mình và người xung quanh.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Gọi Cấp Cứu Trước Khi Hành Động\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi bắt đầu thực hiện bất kỳ biện pháp sơ cứu nào, việc gọi đến số điện thoại cấp cứu là điều quan trọng. Cung cấp thông tin chi tiết về tình hình và tuân theo hướng dẫn từ bác sĩ điều phối giúp đảm bảo có kế hoạch chăm sóc y tế chính xác và nhanh chóng.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            3. Đánh Giá An Toàn Của Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi tiếp cận nạn nhân, hãy đánh giá môi trường xung quanh để đảm bảo an toàn cho cả người cứu thương và người bị nạn. Loại bỏ các nguy cơ tiềm ẩn như lửa, điện áp cao, hoặc vật dụng gây nguy hiểm.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            4. Động Tác Nhẹ Nhàng và Hiệu Quả\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong quá trình thực hiện sơ cứu, hãy luôn tuân thủ nguyên tắc \"động tác nhẹ nhàng\". Tránh gây thêm tổn thương cho nạn nhân và chỉ thực hiện những biện pháp mà bạn đã được đào tạo. Sự nhẹ nhàng kết hợp với hiệu quả sẽ giúp giảm nguy cơ gặp phải tác động phụ không mong muốn.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            5. Đề Xuất Giúp Đỡ Từ Người Xung Quanh\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, không ngần ngại hỏi xem có ai khác có kỹ năng sơ cứu hay không. Sự hợp tác giữa mọi người có thể tăng khả năng cứu sống và giảm áp lực cho người cứu thương chính.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Nhớ rằng, việc thực hiện sơ cứu không chỉ là về việc cứu sống mà còn là về cách làm đúng để đảm bảo an toàn cho tất cả mọi người liên quan. Hãy hiểu rõ và áp dụng những nguyên tắc an toàn này để sẵn sàng đối mặt với mọi tình huống khẩn cấp một cách hiệu quả và an toàn.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2658), null, false, null, null, null },
                    { new Guid("41daf175-b7e1-46ae-9257-3ea027fd7a95"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n       Tư Thế Nằm Nghiêng An Toàn Trong Sơ Cấp Cứu: Biết Để Bảo Vệ Bản Thân và Người Khác\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Nhắc đến sơ cấp cứu, việc biết cách giữ tư thế nằm nghiêng an toàn có thể là yếu tố quyết định giữa sự cứu chữa thành công và biến chứng nghiêm trọng. Trong bài viết này, chúng ta sẽ tìm hiểu về các tư thế nằm nghiêng cơ bản mà bạn có thể áp dụng trong các trường hợp khẩn cấp.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://suckhoe123.vn/uploads/suc-khoe/2021_05/20200424_172336_448622_nghieng.max-1800x1800.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            Tại sao Tư Thế Nằm Nghiêng Quan Trọng?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một số trường hợp, đặc biệt là khi có nguy cơ nôn mửa hoặc hít phải chất lỏng, máu hoặc cơ hội nằm nghiêng có thể ngăn chặn việc phụt ngược chất lỏng vào đường hô hấp, giữ cho đường thoát khí mở rộng và giảm áp lực lên cổ và phổi.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCách Thực Hiện Tư Thế Nằm Nghiêng\r\n        </p>\r\n    </div>\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Tư Thế Nằm Nghiêng Đơn Giản:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp và kéo một chân về phía trên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một bộ phận dưới đầu để giữ cho đầu của họ nghiêng về một bên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đảm bảo đầu và cổ của họ đều ở vị trí tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Tư Thế Nằm Nghiêng Phức Tạp:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một tấm gối hoặc đối vật cứng dưới người bệnh từ dưới đầu đến dưới đùi của họ.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Kéo một chân của họ về phía trên và đặt gối hoặc chăn dưới chân để giữ cho cơ thể họ nghiêng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Giữ đầu và cổ của họ trong một tư thế tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Lưu Ý Quan Trọng\r\nLuôn Giữ Đầu và Cổ Trong Tư Thế Tự Nhiên: Đảm bảo rằng đầu và cổ của người bệnh luôn được giữ trong một tư thế tự nhiên và không bị ép vào bất kỳ hướng nào khi thực hiện tư thế nằm nghiêng.\r\nTheo Dõi Tình Trạng Của Người Bệnh: Luôn lưu ý đến các biểu hiện của người bệnh và sẵn sàng điều chỉnh tư thế nếu cần thiết.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("f3db0b18-003a-4046-873b-264d3498360c"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2675), null, false, null, null, null },
                    { new Guid("541e6a6e-2e89-4973-b6e3-9b643ab60c69"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách Thắt Nút Dây Cơ Bản Mà Bạn Nên Biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Thắt nút là một trong những kỹ năng cơ bản mà ai cũng nên biết, không chỉ trong các hoạt động dã ngoại mà\r\n            còn trong cuộc sống hàng ngày. Từ việc thắt dây giày đến thắt dây dẹt trên thùng đồ, việc biết cách thắt nút\r\n            một cách đúng đắn có thể giúp bạn giữ dây chặt chẽ và an toàn. Trong bài viết này, chúng ta sẽ khám phá 10\r\n            cách thắt nút dây cơ bản mà bạn nên biết.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://chuyendaychi.com/wp-content/uploads/2018/05/n%C3%BAt-th%E1%BA%AFt-d%C3%A2y-th%E1%BA%A3-di%E1%BB%81u.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Nút Dây Dẹt (Overhand Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây dẹt là một trong những nút đơn giản nhất và được sử dụng phổ biến trong cuộc sống hàng ngày. Đây\r\n                là cách thắt nút cơ bản nhất để ngăn dây khỏi tự lỏng ra.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Nút Dây Buộc (Square Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc là một trong những nút được sử dụng rộng rãi để nối hai đoạn dây lại với nhau một cách chắc\r\n                chắn và an toàn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Nút Dây Chặn (Slip Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây chặn là một loại nút có thể điều chỉnh kích thước và được sử dụng để buộc dây một cách nhanh\r\n                chóng và dễ dàng.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Nút Dây Leo Cây (Clove Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo cây là một nút linh hoạt được sử dụng để buộc dây vào một vật thể tròn như cây hoặc ống.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Nút Dây Buông (Bowline Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buông là một trong những nút an toàn nhất để tạo ra một lỗ hoặc vòng không bao giờ tự động co\r\n                lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                6. Nút Dây Buộc Gói (Package Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc gói là một loại nút được sử dụng để buộc chặt các gói hàng hoặc túi.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                7. Nút Dây Buộc Dính (Sheet Bend)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc dính là một cách tốt để nối hai đoạn dây có đường kính khác nhau lại với nhau một cách chắc\r\n                chắn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                8. Nút Dây Leo Núi (Figure Eight Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo núi là một loại nút được sử dụng rộng rãi trong leo núi và leo dã ngoại vì nó giữ dây chắc\r\n                chắn và không bao giờ tự động co lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                9. Nút Dây Buộc Thuyền (Anchor Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc thuyền là một nút đơn giản được sử dụng để buộc dây vào một đinh, cột hoặc vật thể tương\r\n                tự.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                10. Nút Dây Đồng Đều (Trucker's Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây đồng đều là một cách tốt để tạo ra một vòng đeo chắc chắn và được sử dụng rộng rãi trong việc\r\n                buộc chặt và cố định hàng hoặc dụng cụ.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách thắt nút là một kỹ năng quan trọng và hữu ích trong mọi tình huống. Hy vọng rằng bài viết này\r\n                đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện các loại nút cơ bản một cách\r\n                an toàn và hiệu quả. Hãy thực hành thường xuyên để trở thành một chuyên gia thực sự trong việc thắt nút!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2707), null, false, null, null, null },
                    { new Guid("602121ed-dc56-4095-94fd-8e329faedec6"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nCPR - Kỹ Năng Hồi Sinh Tim Phổi Cơ Bản Mà Mọi Người Cần Biết    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong một tình huống khẩn cấp khi người khác đột ngột gặp phải ngừng tim phổi, kỹ năng CPR (Cardiopulmonary Resuscitation) - hồi sinh tim phổi là một kỹ năng quan trọng có thể cứu mạng. Trong bài viết này, chúng ta sẽ tìm hiểu về CPR cơ bản và cách thực hiện nó một cách hiệu quả.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://th.bing.com/th/id/R.3c96bb6b124829db33aa812a1814ee9d?rik=dnxzH5j9nJ0rnw&pid=ImgRaw&r=0\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCPR là gì?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là quá trình cung cấp áp lực hồi sinh tim phổi thông qua việc nén tim và cung cấp hơi thở nhân tạo, nhằm duy trì lưu lượng máu và ôxy đến não và các cơ quan quan trọng khác.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 1: Kiểm Tra An Toàn\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra khu vực xung quanh để đảm bảo an toàn cho bản thân và người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi cấp cứu nếu có sẵn.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 2: Kiểm Tra Tình Trạng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi lên và kiểm tra phản ứng của người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra hơi thở và dấu hiệu sống\r\n        </p>\r\n       \r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 3: Báo Cáo Và Bắt Đầu CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bệnh không hít thở và không có nhịp tim, bắt đầu CPR ngay lập tức.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNén tim: Đặt lòng bàn tay ở giữa ngực, nén tim khoảng 5-6cm sâu với tần suất khoảng 100-120 lần mỗi phút.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nHơi thở nhân tạo: Thực hiện 2 hơi thở nhân tạo với miệng che miệng và mũi người bệnh.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 4: Tiếp Tục CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTiếp tục lặp lại chu trình nén tim và hơi thở cho đến khi cứu thương viên đến hoặc người bệnh hồi phục.\r\n        </p>\r\n    </div>\r\n</div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nLưu Ý Quan Trọng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nThực hiện CPR một cách nhanh chóng và mạnh mẽ, nhưng đồng thời cẩn thận để tránh gây tổn thương.\r\nĐảm bảo bạn đã được đào tạo và tự tin trước khi thực hiện CPR trên người bệnh.\r\n        </p>\r\n    </div>\r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là một kỹ năng quan trọng mà ai cũng nên biết, vì nó có thể là yếu tố quyết định giữa sự sống và cái chết trong một tình huống khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan về CPR và cung cấp thông tin cần thiết để bạn có thể thực hiện nó một cách hiệu quả khi cần thiết. Hãy nhớ, một phút cứu mạng có thể phát huy tác dụng lớn!\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("481abb77-ebd3-47b0-9e9f-718368076074"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2692), null, false, null, null, null },
                    { new Guid("659f4a16-cdc6-4e53-b078-85db873031e7"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            5 Cách Phát Ra Tín Hiệu Cầu Cứu Hiệu Quả Trong Tình Huống Khẩn Cấp\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, khả năng phát ra tín hiệu cầu cứu có thể là yếu tố quyết định giữa sự sống và\r\n            cái chết. Tuy nhiên, không phải ai cũng biết cách phát ra tín hiệu cầu cứu một cách hiệu quả. Trong bài viết\r\n            này, chúng ta sẽ khám phá 5 cách phát ra tín hiệu cầu cứu mà bạn nên biết để có thể thu hút sự chú ý và giúp\r\n            đỡ trong một tình huống khẩn cấp.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://e.khoahoc.tv/photos/image/2015/07/01/SOS_2.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">1. Tiếng Hét Lớn</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách phổ biến nhất để phát ra tín hiệu cầu cứu là hét lớn. Hãy hét càng to càng tốt để\r\n                thu hút sự chú ý của người xung quanh và gửi đi tín hiệu rằng bạn đang gặp vấn đề và cần sự giúp đỡ.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Còi Cứu Hộ\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Mang theo một còi cứu hộ là một ý tưởng tốt để có thể phát ra tín hiệu cầu cứu một cách nhanh chóng và\r\n                dễ dàng. Khi gặp phải tình huống khẩn cấp, bạn chỉ cần thổi vào còi một cách mạnh mẽ để thu hút sự chú ý\r\n                của người xung quanh.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Đèn Pin\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Trong tình huống mà việc gọi cầu cứu bằng tiếng không hiệu quả, việc sử dụng đèn pin có thể là một\r\n                phương tiện hiệu quả khác để thu hút sự chú ý của người xung quanh, đặc biệt là vào ban đêm hoặc trong\r\n                điều kiện ánh sáng yếu.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Gương Soi Ánh Sáng Mặt Trời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn bị mắc kẹt và không thể di chuyển, việc sử dụng một chiếc gương nhỏ hoặc vật phản quang để soi\r\n                ánh sáng mặt trời có thể là một cách hiệu quả để phát ra tín hiệu cầu cứu và thu hút sự chú ý của người\r\n                đi ngang qua.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Biểu Tượng Cầu Cứu Quốc Tế\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một biểu tượng cầu cứu quốc tế như biểu tượng SOS, bạn có thể sử dụng nó để tạo ra tín hiệu\r\n                cầu cứu và gửi đi thông điệp rằng bạn đang cần sự giúp đỡ khẩn cấp.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách phát ra tín hiệu cầu cứu là một kỹ năng quan trọng và có thể cứu sống trong một tình huống\r\n                khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để\r\n                thực hiện điều này một cách an toàn và hiệu quả. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi\r\n                sự thành công trong tình huống khẩn cấp.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2713), null, false, null, null, null },
                    { new Guid("6baa8673-683e-46d6-832c-2bcbb0921546"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách thắt nút dây cơ bản mà bạn nên biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong những tình huống khẩn cấp, khả năng tạo lửa có thể là yếu tố quyết định giữa sự sống và cái chết. Dù\r\n            bạn đang dã ngoại, mắc kẹt trong rừng hoặc gặp phải tình huống khẩn cấp khác, biết cách tạo lửa từ những vật\r\n            dụng cơ bản có thể cực kỳ hữu ích. Trong bài viết này, chúng ta sẽ khám phá những cách tạo lửa đơn giản mà\r\n            bất kỳ ai cũng có thể thực hiện.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://st.quantrimang.com/photos/image/2016/11/08/tao-lua-650.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Sử dụng đánh lửa\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách đơn giản nhất để tạo lửa là sử dụng đánh lửa hoặc bật lửa di động. Đảm bảo rằng bạn\r\n                luôn giữ một chiếc đánh lửa hoặc bật lửa trong túi hoặc trong hành trang của mình.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Que Diêm\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Que diêm là một phương tiện khác để tạo lửa nhanh chóng và dễ dàng. Hãy đảm bảo rằng bạn luôn mang theo\r\n                một số que diêm trong túi hoặc hành trang của mình.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Các Vật Dụng Tự Nhiên\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn không có đánh lửa hoặc que diêm, bạn vẫn có thể tạo lửa bằng cách sử dụng các vật dụng tự nhiên\r\n                như cây khô, lá khô, vỏ cây, hoặc cành cây sấy khô dưới ánh nắng mặt trời.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Kỹ Thuật Friction\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một kỹ thuật khác để tạo lửa là sử dụng ma sát. Bạn có thể sử dụng hai vật dụng có thể tạo ra ma sát\r\n                mạnh mẽ khi chúng va chạm với nhau như các cành cây, bàn tay, hoặc một miếng vải và một cành cây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Kính Lúp\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một kính lúp, bạn có thể sử dụng nó để tập trung ánh nắng mặt trời vào một điểm nhỏ trên vật\r\n                liệu cháy để tạo nên lửa.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách tạo lửa từ những vật dụng cơ bản có thể là một kỹ năng quan trọng trong mọi tình huống khẩn\r\n                cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực\r\n                hiện điều này một cách an toàn và hiệu quả. Đừng quên, luôn luôn lưu ý đến sự an toàn khi làm việc với\r\n                lửa.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2702), null, false, null, null, null },
                    { new Guid("9ea523a3-40bc-4dcc-aff7-a470ed73376f"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nHướng Dẫn Vận Chuyển Người Bệnh An Toàn Trong Mọi Tình Huống\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Việc vận chuyển người bệnh là một phần quan trọng trong sơ cứu và chăm sóc y tế. Tuy nhiên, nếu không thực hiện đúng cách, nó có thể gây ra thêm tổn thương và biến chứng cho người bệnh. Trong bài viết này, chúng ta sẽ tìm hiểu về cách vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://baoquangbinh.vn/dataimages/202107/original/images704000_cc3.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi vận chuyển bất kỳ người bệnh nào, hãy đánh giá tình hình và quyết định liệu có cần gọi xe cấp cứu hay không. Nếu không có xe cấp cứu, đảm bảo rằng bạn có đủ sự trang bị và kiến thức để vận chuyển một cách an toàn.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Chuẩn Bị Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nĐảm bảo không gian vận chuyển rộng rãi và an toàn.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLoại bỏ các vật dụng nguy hiểm khỏi lối đi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLàm cho không gian thoáng đãng và dễ dàng tiếp cận.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sử Dụng Kỹ Thuật Đúng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng các kỹ thuật vận chuyển như chuyển lên giường, ghế hoặc xe lăn một cách cẩn thận và nhẹ nhàng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn sử dụng tư thế bảo vệ cho cơ thể của người bệnh, đặc biệt là đầu, cổ và cột sống.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng hỗ trợ bổ sung như gối, băng cố định và dây đai an toàn nếu cần thiết.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n4. Giao Tiếp Và Động Viên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn giữ liên lạc với người bệnh và cung cấp sự động viên và an ủi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGiải thích mọi động tác và kế hoạch di chuyển trước khi thực hiện.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n5. Sự Theo Dõi Sau Khi Vận Chuyển\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSau khi đặt người bệnh vào vị trí mới, đảm bảo rằng họ đang cảm thấy thoải mái và không gặp phải bất kỳ vấn đề nào.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra các dấu hiệu và triệu chứng có thể báo hiệu về tình trạng tồn tại hoặc mới.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Việc vận chuyển người bệnh đòi hỏi sự chuẩn bị kỹ lưỡng, kiến thức và kỹ năng. Quan trọng nhất là phải luôn đặt sự an toàn và thoải mái của người bệnh lên hàng đầu. Hy vọng rằng với những hướng dẫn trên, bạn sẽ có thêm niềm tin và kiến thức để vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2687), null, false, null, null, null },
                    { new Guid("d9c3179b-5c53-410f-9d06-dab05f300c7b"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nSơ Cứu Cho Thao Tác Heimlich: Biết Cách Cứu Mạng Trong Trường Hợp Hóc Thức Ăn\r\n</h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong tình huống khẩn cấp khi một người đang bị hóc thức ăn và không thể nói hoặc thở, thao tác Heimlich là một kỹ năng cứu mạng quan trọng. Trong bài viết này, chúng ta sẽ tìm hiểu cách thực hiện thao tác Heimlich một cách đúng đắn để cứu mạng cho người đang bị hóc.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://www.topontiki.gr/wp-content/uploads/2023/08/Untitled-design-2023-08-14T190744.334.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\"> \r\nTrước tiên, hãy đảm bảo rằng người đó thực sự đang bị hóc thức ăn và không thể nói hoặc thở. Nếu họ vẫn có thể nói hoặc ho thở, họ có thể tự giải quyết vấn đề và bạn chỉ cần đề xuất họ làm theo.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Thực Hiện Thao Tác Heimlich\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đứng phía sau: Đứng phía sau người bị hóc, đặt một chân giữa chân họ để tạo sự ổn định.        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Bám vào phía sau: Đặt một bàn tay lớn vào phía trên của hốc ngực của họ, đặt còn lại vào phía dưới, trên phần dưới của lồng ngực.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Thực hiện cú đẩy: Đẩy mạnh và nhanh chóng vào trong và lên trên, hướng ra phía trên, nhưng không đặt quá cao lên phần xương sườn.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Lặp lại nếu cần thiết: Lặp lại cú đẩy cho đến khi vật thể bị hóc được thải ra hoặc cho đến khi đội cứu hộ đến.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sự Theo Dõi Và Hỗ Trợ Sau Khi Thực Hiện\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTheo dõi người bị hóc cho đến khi họ hoàn toàn ổn định.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bị hóc mất ý thức hoặc ngừng hô hấp, thực hiện CPR ngay lập tức.\r\n        </p>\r\n       \r\n    </div>\r\n    \r\n   \r\n  \r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n           Thao tác Heimlich là một kỹ năng cứu mạng quan trọng mà mọi người nên biết. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện thao tác Heimlich một cách an toàn và hiệu quả trong trường hợp cần thiết. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi sự thành công trong sơ cứu.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2699), null, false, null, null, null },
                    { new Guid("dc04ad98-67bb-44f5-9d44-52118cea6b74"), null, "    <div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            Bí Quyết Xác Định Phương Hướng Bằng Lá Cây: Kỹ Năng Sinh Tồn Cơ Bản\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong các tình huống khẩn cấp hoặc khi bị lạc trong thiên nhiên, việc biết cách xác định phương hướng có thể\r\n            là yếu tố quyết định giữa sự sống và cái chết. Mặc dù hiện đại có nhiều công nghệ giúp xác định hướng, nhưng\r\n            việc sử dụng các phương tiện tự nhiên như lá cây vẫn là một kỹ năng cơ bản mà bất kỳ ai cũng nên biết. Trong\r\n            bài viết này, chúng ta sẽ khám phá cách sử dụng lá cây để xác định phương hướng.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://bizweb.dktcdn.net/100/032/885/files/cac-ky-nang-sinh-ton-trong-rung-ban-nen-biet.jpg?v=1664768241728\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Lá Cây Như Một Dụng Cụ Xác Định Phương Hướng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá cây có thể được sử dụng để xác định hướng chính xác bằng cách nhìn vào cách mà các lá hình dạng và\r\n                màu sắc của chúng thay đổi dựa trên hướng mặt trời.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Hướng Dựa Trên Sự Chiếu Sáng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá Cây Láng: Lá cây sẽ láng hơn ở phía nam so với phía bắc vì mặt trời chiếu sáng trực tiếp vào phía\r\n                nam. Kích Thước Của Bóng Dáng: Khi mặt trời ở trên đỉnh, bóng của cây sẽ nằm ở phía dưới cây về phía\r\n                phía đông. Khi mặt trời ở phía tây, bóng của cây sẽ nằm ở phía dưới cây về phía tây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Cây Cây Đồng Thời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Tập Trung: Các cây sẽ tập trung nhiều ở phía bắc vì phía nam thường có ít ánh sáng mặt trời\r\n                hơn.\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Dày Đặc: Cây sẽ dày đặc hơn ở phía nam do nhận được nhiều ánh sáng mặt trời hơn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">4. Sự Thực Hành</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Thực hành thường xuyên và thử nghiệm với lá cây để làm quen với cách chúng phản ánh ánh sáng và hướng\r\n                của mặt trời trong các điều kiện khác nhau.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách sử dụng lá cây để xác định phương hướng là một kỹ năng cơ bản và quan trọng trong việc sinh\r\n                tồn trong môi trường tự nhiên. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến\r\n                thức cần thiết để thực hiện điều này một cách hiệu quả. Hãy thực hành và trở thành một bậc thầy trong\r\n                việc xác định hướng bằng lá cây!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"), null, new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2710), null, false, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("07f89298-3fe2-4f16-a33d-209a7feb9526"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0a4e0c7b-3455-4d10-a25c-d5d78e84efb1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0c3aa435-c958-4152-a7a6-309bf52337d0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0cff733f-47e0-4656-b356-557d02ef9f9c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0de1b351-990b-49d2-b1d9-aff6f2f6c0e2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e6d3177-7510-4290-8ae7-02c7dcf2bd46"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("116c0f70-7610-4383-9c5f-10cd086f198a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("15f7c3e2-71bf-4c82-95a7-d49ef1b76e99"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("17676ce9-6d78-489b-8803-a651875391e9"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1e9dae67-083c-40a3-9d33-1de20e22c900"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("201cafab-4d18-461e-83db-3f15ad9ba19c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2162f4cd-abe5-4945-ac9c-49c2e12acc88"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("22034197-b916-4c2a-b8b5-cc60ec336b20"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2563e2fa-324f-41a0-b780-7034fb55152b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2803f828-f218-4eae-b560-19b1c4903c96"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2977fa59-3ebe-407c-b804-42c381020f74"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("299b419b-4894-4d0e-820f-e62774aab8c6"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("29ef856c-1ceb-4ce4-8de0-adebd76d8589"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2b581b39-6ff7-465e-b28d-8e8dbdef52aa"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2de49840-07b0-478c-b045-a46e311bfc2d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2e524aca-1a0f-4125-a7c7-da24663d327b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("346a6ce7-fd63-4788-9c8d-72da3a606b20"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3985bbaa-790d-4301-a500-02c0feac422f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3fce95fa-36d0-452f-912f-a66689bcd54f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f3b8ce-43a1-4256-a8ae-9d96ea94f127"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f9158a-50bb-4800-b104-7f43f452b4da"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("41fa54be-cb59-42ad-a6bd-48f705b7bd7a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("45dc3263-0892-40fa-bc5b-2a9cd86be147"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("4787dab5-0205-412a-a0b3-d15f716a25f1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("479d98e3-0a00-4294-9678-f0e03bd75048"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("53ab9697-804f-4492-93c7-cfcf2c975c2a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("55c613db-7c7d-4c61-aaba-bdfb6ee2222b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("57b75328-ba3b-4c89-af42-f3f98f6460ec"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5e313fda-e478-4f37-9bd8-2310ed956e41"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5f589b73-6307-4ba1-9b6e-a0aea9dbb10a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("616fcfd4-aad3-4881-8fc2-cfbbfa2077dd"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("632ba757-0dc2-4a89-8462-285041471db2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("6e3bd858-0dad-4cfb-ad3c-18ea0a51ba59"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7179302f-70cf-482c-9027-f94ed74ff7a1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("773c3118-1127-4c00-b8ae-4acf2fff8e84"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("79509a95-2ce1-496e-82f6-98b31940c359"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7978618a-d7be-4975-8db9-648a435925ce"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("80ca4742-e86a-4b7e-b1de-7d71184ee956"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("81725d34-8224-438c-995e-2a02006295fb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("886cee20-5a0a-4f87-a059-aa0759c065d4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89d12998-fd7a-4858-8f65-6ca330469d80"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8c19130d-a281-47f4-9753-697267f4ecbd"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8d5d44f6-39a9-4483-b121-ba884210360a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("905a8ca1-92ef-445f-a4aa-1838d653af5b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("910cae89-7155-499f-8b69-0071b959fe59"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9420bbd8-3702-438b-9470-9fa5fff9a0ba"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("94c10218-2f11-4892-a64d-2c729f254536"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9951c3aa-3245-4a3b-ae23-26339b08ece0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9ae701b5-c513-4d0b-a2b1-eef8ef995e18"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9e6064b5-db1e-456f-b113-0034f1a6fdd4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a4dca733-6788-469b-9980-6da0759e8089"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a5f66dd3-7f64-4f32-90b3-19a8615380ab"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a6205571-be0e-4b95-9ffd-a5addedb4bd7"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a82eaf8a-5cb2-4815-9394-59110a2a3699"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa158c9c-5a68-4059-b1ae-e4085adcd51f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa97700c-2471-4845-87c7-4d5d19e4e835"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa9d9c94-ce3f-42a2-acff-84f85608748c"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ac02f0ed-e9be-4cfa-99c8-2aa060954bd9"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aed8237a-800e-47da-8aa7-b8935b0d4401"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("af068e17-d32c-43e2-9f3a-af0602ff6731"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b02698b9-8560-4c1b-967b-8c4cf7c68c03"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b1b7706a-3faa-4943-a8b2-6d3854a47ec4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8a7ec77-865b-4864-b52c-e0951b48e322"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8da47d7-edd8-484a-b06d-691a07b2739f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b9ea8984-a752-4ac4-8bf2-e30a90e497d0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ba4b51a1-460c-4a32-801e-1c65b8d624b5"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc199684-de95-437c-8d1a-8c1e8f6cc1d2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc5db5fe-b982-44e6-a591-b2596ccd5522"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bf2ea4b1-05db-4175-96ca-87008a609fe9"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("c88d5f35-4c11-42a4-b355-d0052b08687e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd8eb190-a455-4f5f-bc21-8900c829ad46"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cec9cab3-beaf-440e-88ef-91452dc4b077"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ceca8b5d-a8c6-457f-a681-eebcfacfe9f4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d3a98af4-5c3e-4b87-9938-788264ff9a36"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d53d9426-a3d9-401c-b7b3-7af4974a6572"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d8f9cc58-73bb-49cb-b8a5-c9693ff067de"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("dab66311-12f2-44ce-8719-83d67e21bfdd"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("de66382b-5819-4d2c-b0af-37e7eaf682b5"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("df288229-2da4-4832-9913-70c1a7e05e8f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e091b4cd-98f8-4fe3-97ba-9c016c7822e2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e57daddb-f9b7-483b-b4ab-153957577e7f"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e66354a9-760d-4826-a002-04a81ba09c8d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e848a319-5e9a-4dba-975d-8c1e5247a97a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eea55b8b-fa03-4ecb-819a-ca9a6f9d43ef"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eebeef97-4736-476c-99af-dfd4ed9f5255"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("efe5f9c2-9615-41b1-a4db-b229dea17bef"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f160154b-b34a-49f6-89a8-0f80311d0641"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f4f0a748-18a6-4546-b4d0-62ac473c7394"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("fbf0061b-5f88-45f1-8546-ca2e9d5ed35d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("01ea28b2-56ff-44e8-883a-ef8890bd426d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("090a2b95-7b45-4600-ad80-dd2853cc9685"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0cb0d678-9454-4391-bd9e-2b536a50f1f7"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("61105e2b-b22e-4eb2-897f-941818211986"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c57b22b-c472-419c-ad81-ee87410c36de"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("831c6f2e-7c32-4ae6-8af6-fdb3897c612b"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("8ef3e270-6c5a-4393-9060-de98e98e6e84"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("a7247c61-4ce6-478c-8c6f-56df1c72fe1d"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("bfe028fa-949f-44c8-95c9-fbb4537114c9"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c55d01ce-f82b-4ef4-b9b2-42452d718e50"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 3, 21, 0, 40, 35, 290, DateTimeKind.Local).AddTicks(2480));
        }
    }
}
