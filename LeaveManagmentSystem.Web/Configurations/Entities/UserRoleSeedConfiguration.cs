using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagmentSystem.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "fcba128b-d38e-2a67-1912-f6b94351da92",
                    UserId = "404ab940-3c84-3342-1912-7468ea63b949"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "fdcb128b-d48e-2b67-1913-f6c94351da93",
                    UserId = "fcab128b-d58e-4b67-9462-f6b94350da91"
                }
            );
        }
    }
}