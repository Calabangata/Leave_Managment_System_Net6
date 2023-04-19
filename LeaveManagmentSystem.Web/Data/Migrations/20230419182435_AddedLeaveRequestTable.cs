using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcba128b-d38e-2a67-1912-f6b94351da92",
                column: "ConcurrencyStamp",
                value: "3d15de57-d9fc-4eab-af8f-2359d6f6c260");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcb128b-d48e-2b67-1913-f6c94351da93",
                column: "ConcurrencyStamp",
                value: "beb1814a-b7fd-479f-b0a1-ecefe79b92eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404ab940-3c84-3342-1912-7468ea63b949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9068c365-9834-44be-bcc4-aaa351c39d74", "AQAAAAEAACcQAAAAEH3GTrScz6GOJnMnSiUUc5BplUNtvRdLPqDEiF57WAE0XewaXYFmtHLhFsgXVtDs4w==", "0a1702f4-b8da-462a-bdb4-a7e49ab59f5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcab128b-d58e-4b67-9462-f6b94350da91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c68bea89-294e-4f43-b65c-db49b5ca6f44", "AQAAAAEAACcQAAAAEKyZTtEg4JuwPYHPFDcxZBZAz3ijJ8Nf3XYpES8BjKsT9LarHHmizm88OP5aARWvKQ==", "4cbdfe85-faf5-4ef6-96e7-e4e59d5c0027" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
