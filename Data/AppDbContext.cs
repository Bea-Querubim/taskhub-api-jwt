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
    }
}