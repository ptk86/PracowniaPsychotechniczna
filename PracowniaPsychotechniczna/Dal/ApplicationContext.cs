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
            
            builder.Entity<Badany>().HasIndex(p => p.Pesel).IsUnique();

            builder.Entity<Firma>().HasIndex(p => p.Nip).IsUnique();

            builder.Entity<FirmaBadanie>().HasKey(fb => new {fb.FirmaId, fb.BadanieId});
            builder.Entity<FirmaBadanie>().HasOne(fb => fb.Badanie).WithOne(b => b.FirmaBadanie);
            builder.Entity<FirmaBadanie>().HasOne(fb => fb.Firma).WithMany(b => b.FirmaBadanieList).HasForeignKey(fb => fb.FirmaId);

            builder.Entity<Badanie>().ToTable("Badanie");
        }

        public DbSet<Psycholog> Psycholog { get; set; }

        public DbSet<TypBadania> TypBadania { get; set; }

        public DbSet<Firma> Firma { get; set; }

        public DbSet<Badany> Badany { get; set; }
    }
}
