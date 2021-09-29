using proj_semestre_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace proj_semestre_backend.Database {  
    public partial class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options)
          : base(options){}
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Movement> Movements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => new { u.Username })
                .IsUnique(true);
            
            modelBuilder.Entity<Card>()
                .HasIndex(c => new { c.Number })
                .IsUnique(true);

            modelBuilder.Entity<Movement>()
            .Property(f => f.Id)
            .ValueGeneratedOnAdd();
            
            modelBuilder.Entity<Movement>()
                .HasIndex(m => new { m.Id })
                .IsUnique(true);
        }
    }
}