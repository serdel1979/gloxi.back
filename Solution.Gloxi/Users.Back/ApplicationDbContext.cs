
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Users.Back
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed roles
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "ROOT",
                    NormalizedName = "ROOT"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "SUPERROOT",
                    NormalizedName = "SUPERROOT"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "USER",
                    NormalizedName = "USER"
                }
            );
        }

    }
}
