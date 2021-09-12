using proj_semestre_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace proj_semestre_backend.Database {  
    public partial class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions options)
          : base(options){}
        public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => new { u.Username })
            .IsUnique(true);
    }
    }}