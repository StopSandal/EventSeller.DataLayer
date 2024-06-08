using DataLayer.Model.EF;
using EventSeller.DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;

#nullable disable

namespace EventSeller.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesAndFirstAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
           table: "AspNetRoles",
           columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
           values: new object[,]
           {
                { "1", "Basic", "BASIC", Guid.NewGuid().ToString() },
                { "2", "Event manager", "EVENT MANAGER", Guid.NewGuid().ToString() },
                { "3", "Venue manager", "VENUE MANAGER", Guid.NewGuid().ToString() },
                { "4", "Admin", "ADMIN", Guid.NewGuid().ToString() },
                { "5", "Super admin", "SUPER ADMIN", Guid.NewGuid().ToString() }
           });

            // Create an admin user
            var adminUserId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<IdentityUser>();
            var passwordHash = hasher.HashPassword(null, "1111");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "UserName", "NormalizedUserName", "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash", "SecurityStamp", "ConcurrencyStamp", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnabled", "AccessFailedCount" },
                values: new object[]
                {
                adminUserId,
                "admin",
                "ADMIN",
                "admin@example.com",
                "ADMIN@EXAMPLE.COM",
                true,
                passwordHash,
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString(),
                false,
                false,
                true,
                0
                });

            // Assign admin role to the admin user
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { adminUserId, "5" }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
