using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    public partial class UpdatedRequestCommentsNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fcba128b-d38e-2a67-1912-f6b94351da92",
                column: "ConcurrencyStamp",
                value: "2bf1ed00-4ba9-4088-9928-4b088ecc1237");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdcb128b-d48e-2b67-1913-f6c94351da93",
                column: "ConcurrencyStamp",
                value: "c10e5c35-7a5c-44c3-8fe8-4a6cf5fd4d0a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404ab940-3c84-3342-1912-7468ea63b949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c18f2874-1e1b-429a-85d3-954ee6347f04", "AQAAAAEAACcQAAAAENdbLTeB0Wq5JTbPqemoc3TKP/A6NDMcd83OWZicasxgz8S9GqT9nKFg1cURR/Pcxw==", "eeff6f8b-1e98-42e0-bdf1-3c539f7bb23c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcab128b-d58e-4b67-9462-f6b94350da91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb03a98a-7c4c-4495-a3c5-d4e36008813a", "AQAAAAEAACcQAAAAEOCvZJnzx+YJsUA4SNqpxsGzpV3GNRH1Jr5IUPe/C6wLBAfHyD+VT3tlK5c1Op+w6A==", "ce5058fc-9749-4060-8a8f-87c15aaa7bed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
