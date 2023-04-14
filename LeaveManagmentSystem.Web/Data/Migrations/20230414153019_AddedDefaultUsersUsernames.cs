using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcba128b-d38e-2a67-1912-f6b94351da92",
                column: "ConcurrencyStamp",
                value: "964a9e01-c99b-4510-bb9d-93f33e7da798");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcb128b-d48e-2b67-1913-f6c94351da93",
                column: "ConcurrencyStamp",
                value: "0683b82f-0a39-4096-afa4-639d7e2c7214");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404ab940-3c84-3342-1912-7468ea63b949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "188a15ed-9e9d-49f1-9184-96d669aee5de", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAENbBxKGPjMRb87AvBg95+mUI3+v78+Ag3oisJn4JmfVwx+Gt7eJbEBtZvkO3WPRREg==", "affe8deb-d73a-45b3-b842-6ef72dba16d0", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcab128b-d58e-4b67-9462-f6b94350da91",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f57769fe-65da-440c-a295-cde68bdbe292", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBUwhYPLVWa5JlLGoAkt7BpwEcBDHdqwnDIcteUEUHKNeXwb9YypqlIs0TwlHBGiEA==", "db87a59d-f1c1-4a55-bad9-f42ff2eff4d2", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcba128b-d38e-2a67-1912-f6b94351da92",
                column: "ConcurrencyStamp",
                value: "217fa0de-c180-4556-95f9-92c828a0b985");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcb128b-d48e-2b67-1913-f6c94351da93",
                column: "ConcurrencyStamp",
                value: "ea3cbd90-9226-4e65-b173-8dbe32e603ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404ab940-3c84-3342-1912-7468ea63b949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "605cef9d-d27b-4178-8a43-684bd1c411df", false, null, "AQAAAAEAACcQAAAAEFYJQ4p+EQPQyBP/Ba7FtrvwKKna6xDJDmNxwiVGtELBcJFXO00D3MnO6OiSNgV2PQ==", "bee88807-2f0a-4067-865c-cc27ad570a71", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcab128b-d58e-4b67-9462-f6b94350da91",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "028592cb-e7f1-4de2-bd58-b06953fc6658", false, null, "AQAAAAEAACcQAAAAENTC7iyL/fSfBdMMkWSeevdUh7sAsELrAqvR/OipoInojfCIfIlU39idkQ79cSwtgw==", "6dc80544-2d03-43de-934e-816ef1ed8189", null });
        }
    }
}
