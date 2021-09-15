using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace DevDotNet.Data
{
    public sealed class DevDotContext: DbContext
    {
        public DbSet<Project> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=prGitHub;Username=postgres;Password=Aznn7112");
        }
    }
}