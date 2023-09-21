using Microsoft.EntityFrameworkCore;
using ZooCore.Datas;
using ZooCore.Models;

namespace ZooAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Species> Species { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Species>().HasData(InitialSpecies.zooSpecies);
            modelBuilder.Entity<Animal>().HasData(InitialAnimal.Animals);
        }
    }
}
