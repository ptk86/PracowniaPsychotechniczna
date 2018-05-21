using Microsoft.EntityFrameworkCore;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Dal
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Badanie> Badanies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Badany>().HasIndex(p => p.Pesel).IsUnique();
            builder.Entity<Firma>().HasIndex(p => p.Nip).IsUnique();
        }

        public DbSet<Psycholog> Psycholog { get; set; }

        public DbSet<TypBadania> TypBadania { get; set; }

        public DbSet<Firma> Firma { get; set; }

        public DbSet<Badany> Badany { get; set; }
    }
}
