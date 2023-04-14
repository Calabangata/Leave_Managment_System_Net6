using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fcba128b-d38e-2a67-1912-f6b94351da92", "217fa0de-c180-4556-95f9-92c828a0b985", "Administrator", "ADMINISTRATOR" },
                    { "fdcb128b-d48e-2b67-1913-f6c94351da93", "ea3cbd90-9226-4e65-b173-8dbe32e603ae", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "404ab940-3c84-3342-1912-7468ea63b949", 0, "605cef9d-d27b-4178-8a43-684bd1c411df", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEFYJQ4p+EQPQyBP/Ba7FtrvwKKna6xDJDmNxwiVGtELBcJFXO00D3MnO6OiSNgV2PQ==", null, false, "bee88807-2f0a-4067-865c-cc27ad570a71", null, false, null },
                    { "fcab128b-d58e-4b67-9462-f6b94350da91", 0, "028592cb-e7f1-4de2-bd58-b06953fc6658", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAENTC7iyL/fSfBdMMkWSeevdUh7sAsELrAqvR/OipoInojfCIfIlU39idkQ79cSwtgw==", null, false, "6dc80544-2d03-43de-934e-816ef1ed8189", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fcba128b-d38e-2a67-1912-f6b94351da92", "404ab940-3c84-3342-1912-7468ea63b949" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fdcb128b-d48e-2b67-1913-f6c94351da93", "fcab128b-d58e-4b67-9462-f6b94350da91" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fcba128b-d38e-2a67-1912-f6b94351da92", "404ab940-3c84-3342-1912-7468ea63b949" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fdcb128b-d48e-2b67-1913-f6c94351da93", "fcab128b-d58e-4b67-9462-f6b94350da91" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcba128b-d38e-2a67-1912-f6b94351da92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcb128b-d48e-2b67-1913-f6c94351da93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404ab940-3c84-3342-1912-7468ea63b949");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcab128b-d58e-4b67-9462-f6b94350da91");
        }
    }
}
