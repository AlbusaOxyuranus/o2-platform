using Microsoft.EntityFrameworkCore;
using O2Platform.Certificate.API.Data.Models.O2C;

namespace O2Platform.Certificate.API.Data
{
    public class O2BusinessDataContext : DbContext
    {
        #region Ctors

        public O2BusinessDataContext(DbContextOptions<O2BusinessDataContext> options)
            : base(options)
        {

        }

        #endregion

        #region Fields

        #region O2C

        public virtual DbSet<O2CContact> O2CContact { get; set; }
        public virtual DbSet<O2CCertificate> O2CCertificate { get; set; }
        public virtual DbSet<O2CLocation> O2CLocation { get; set; }
        public virtual DbSet<O2CPhoto> O2CPhoto { get; set; }

        public virtual DbSet<O2CCertificateLocation> O2CCertificateLocation { get; set; }
        #endregion
        
        // public virtual DbSet<Audit> Audits { get; set; }
        
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<O2CCertificateLocation>().HasKey(bc => new { CertificateOwnerLocationId = bc.O2CLocationId, bc.O2CCertificateId });

            modelBuilder.Entity<O2CCertificateLocation>()
                .HasOne(bc => bc.O2CCertificate)
                .WithMany(b => b.Locations)
                .HasForeignKey(bc => bc.O2CCertificateId);

            modelBuilder.Entity<O2CCertificateLocation>()
                .HasOne(bc => bc.O2CLocation)
                .WithMany(c => c.O2CCertificateLocation)
                .HasForeignKey(bc => bc.O2CLocationId);

            modelBuilder.Entity<O2CPhoto>()
                .HasKey(e => new { e.Id, e.O2CCertificateId});

            modelBuilder.Entity<O2CPhoto>()
                .HasOne(e => e.O2CCertificate)
                .WithMany(e => e.Photos)
                .HasForeignKey(e => e.O2CCertificateId)
                .OnDelete(DeleteBehavior.Cascade); // <= This entity has cascading behaviour on deletion
            
            base.OnModelCreating(modelBuilder);
        }
    }
    
    
}