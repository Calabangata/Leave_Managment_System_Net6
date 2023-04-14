using LeaveManagmentSystem.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentSystem.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var Hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "404ab940-3c84-3342-1912-7468ea63b949",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = Hasher.HashPassword(null, "P@ssword2"),
                    EmailConfirmed = true

                },
                new Employee
                {
                    Id = "fcab128b-d58e-4b67-9462-f6b94350da91",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = Hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true

                }
            );
        }
    }
}