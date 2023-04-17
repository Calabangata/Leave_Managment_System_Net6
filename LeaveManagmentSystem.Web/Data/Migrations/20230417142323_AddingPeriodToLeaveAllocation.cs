using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    public partial class AddingPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcba128b-d38e-2a67-1912-f6b94351da92",
                column: "ConcurrencyStamp",
                value: "e83cc552-c314-408e-99ec-9a7893074b85");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcb128b-d48e-2b67-1913-f6c94351da93",
                column: "ConcurrencyStamp",
                value: "b2d4ccac-604e-47b9-8bf7-22f1e208a892");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404ab940-3c84-3342-1912-7468ea63b949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1344a20-e21e-4a16-9415-82c6b20cd33e", "AQAAAAEAACcQAAAAEH3RzjYaa0ybBikAoPfO9rAv3jcyT1Bl5GEj9QSbLILnG72A5KCsLl7BOq9YYEFe1A==", "c4025515-d091-4a0f-9630-089c5117b305" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcab128b-d58e-4b67-9462-f6b94350da91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cb1aefb-5fed-4c33-9009-ada18b4c3a32", "AQAAAAEAACcQAAAAEDFrSCOQW8BCmsVOqOeG+amkAter3MRsdxPBWZ0uAR/LkEiQpvPftoEmMxZOXYYN7g==", "eee5cd48-665c-4015-97fc-b0f784fd75de" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "188a15ed-9e9d-49f1-9184-96d669aee5de", "AQAAAAEAACcQAAAAENbBxKGPjMRb87AvBg95+mUI3+v78+Ag3oisJn4JmfVwx+Gt7eJbEBtZvkO3WPRREg==", "affe8deb-d73a-45b3-b842-6ef72dba16d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcab128b-d58e-4b67-9462-f6b94350da91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f57769fe-65da-440c-a295-cde68bdbe292", "AQAAAAEAACcQAAAAEBUwhYPLVWa5JlLGoAkt7BpwEcBDHdqwnDIcteUEUHKNeXwb9YypqlIs0TwlHBGiEA==", "db87a59d-f1c1-4a55-bad9-f42ff2eff4d2" });
        }
    }
}
