using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwitterClone.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RoleBasesAAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("ab069366-28e0-485a-81ca-9c1bc439ec10"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(1457), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "users.delete" },
                    { new Guid("d2d58110-2690-460c-9f11-05633234ea37"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(1459), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "roles.manage" },
                    { new Guid("ed986696-6f4a-49a6-a4da-cd072c4a3020"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(1454), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "users.read" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("35c51d71-265b-4d16-8bf2-0133c505769c"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(3003), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "User" },
                    { new Guid("7a7513f6-60f0-4f86-bd59-c42c8146181e"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(3002), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Moderator" },
                    { new Guid("b1ca7713-bc3c-4eb1-bf3b-d97cbcb6c745"), new DateTime(2026, 11, 25, 15, 44, 35, 505, DateTimeKind.Utc).AddTicks(2998), new Guid("00000000-0000-0000-0000-000000000000"), null, null, "Admin" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_Name",
                table: "Permissions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
