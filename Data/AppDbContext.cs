using Microsoft.EntityFrameworkCore;
using TaskHub.Api.Models;

namespace TaskHub.Api.Data
{
    public class AppDbContext : DbContext
    {
        //construtor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        /* Other kind of constructor -- used in Console Apps
        private readonly string _connectionString;

        public AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }
        */

        //Define Entities after init constructor DbContext
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.Username)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.HasIndex(u => u.Username).IsUnique();

                entity.Property(u => u.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.HasIndex(u => u.Email).IsUnique();

            });

            modelBuilder.Entity<TaskItem>(

                entity =>
                {
                    entity.Property(t => t.Title)
                        .IsRequired()
                        .HasMaxLength(100);
    
                    entity.Property(t => t.Description)
                        .HasMaxLength(500);
    
                    entity.HasOne(t => t.User)
                        .WithMany(u => u.Tasks)
                        .HasForeignKey(t => t.UserId)
                        .OnDelete(DeleteBehavior.Cascade);
                }
            );

            base.OnModelCreating(modelBuilder);

        }
    }
}