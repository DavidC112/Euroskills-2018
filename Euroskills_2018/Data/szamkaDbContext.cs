using Microsoft.EntityFrameworkCore;
using Euroskills_2018.Models;


namespace Euroskills_2018.Data
{
    public class szamkaDbContext : DbContext
    {
        public szamkaDbContext(DbContextOptions<szamkaDbContext> options)
            : base(options)
        {
        }
        public DbSet<Versenyzo> Versenyzo { get; set; }
        public DbSet<Orszag> Orszag { get; set; }
        public DbSet<Szakma> Szakma { get; set; }
    }
}
