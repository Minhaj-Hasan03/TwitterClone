using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwitterClone.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfileFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("55eb7f4a-156c-4de7-a9d4-39fdb6be6556"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("712fe51f-db7e-4fe4-9d75-34c6cad6b368"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("8ad2930c-9e9e-4117-8c01-c0cccd1f9988"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("dea7efbd-0f1f-4204-b8bd-26480df4c967"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("f4fbf05a-21ce-41fa-bece-6baaa1110152"));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ab069366-28e0-485a-81ca-9c1bc439ec10"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d2d58110-2690-460c-9f11-05633234ea37"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed986696-6f4a-49a6-a4da-cd072c4a3020"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("28c53dc1-d3da-4882-9905-cf7e9fd8fc1f"), new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(8952), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ab069366-28e0-485a-81ca-9c1bc439ec10"), new Guid("7a7513f6-60f0-4f86-bd59-c42c8146181e") },
                    { new Guid("3374db36-3720-4b7b-94ac-23aaf55f0b34"), new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(8932), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ed986696-6f4a-49a6-a4da-cd072c4a3020"), new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745") },
                    { new Guid("552636fe-a1d6-4364-a6aa-a3befc49c562"), new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(8938), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ab069366-28e0-485a-81ca-9c1bc439ec10"), new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745") },
                    { new Guid("712cf0ec-1c83-4000-bf43-7cd8c4b8a36c"), new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(8948), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("d2d58110-2690-460c-9f11-05633234ea37"), new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745") },
                    { new Guid("eb720187-45af-4533-afd6-730404d796d4"), new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(8950), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ed986696-6f4a-49a6-a4da-cd072c4a3020"), new Guid("7a7513f6-60f0-4f86-bd59-c42c8146181e") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("35c51d71-265b-4d16-8bf2-0133c505769c"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7a7513f6-60f0-4f86-bd59-c42c8146181e"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 26, 6, 12, 24, 297, DateTimeKind.Utc).AddTicks(2946));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("28c53dc1-d3da-4882-9905-cf7e9fd8fc1f"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("3374db36-3720-4b7b-94ac-23aaf55f0b34"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("552636fe-a1d6-4364-a6aa-a3befc49c562"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("712cf0ec-1c83-4000-bf43-7cd8c4b8a36c"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("eb720187-45af-4533-afd6-730404d796d4"));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ab069366-28e0-485a-81ca-9c1bc439ec10"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d2d58110-2690-460c-9f11-05633234ea37"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed986696-6f4a-49a6-a4da-cd072c4a3020"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("55eb7f4a-156c-4de7-a9d4-39fdb6be6556"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(7962), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("d2d58110-2690-460c-9f11-05633234ea37"), new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745") },
                    { new Guid("712fe51f-db7e-4fe4-9d75-34c6cad6b368"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(7954), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ed986696-6f4a-49a6-a4da-cd072c4a3020"), new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745") },
                    { new Guid("8ad2930c-9e9e-4117-8c01-c0cccd1f9988"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(7960), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ab069366-28e0-485a-81ca-9c1bc439ec10"), new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745") },
                    { new Guid("dea7efbd-0f1f-4204-b8bd-26480df4c967"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(7974), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ab069366-28e0-485a-81ca-9c1bc439ec10"), new Guid("7a7513f6-60f0-4f86-bd59-c42c8146181e") },
                    { new Guid("f4fbf05a-21ce-41fa-bece-6baaa1110152"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(7964), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new Guid("ed986696-6f4a-49a6-a4da-cd072c4a3020"), new Guid("7a7513f6-60f0-4f86-bd59-c42c8146181e") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("35c51d71-265b-4d16-8bf2-0133c505769c"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7a7513f6-60f0-4f86-bd59-c42c8146181e"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745"),
                column: "CreatedAt",
                value: new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(2998));
        }
    }
}
