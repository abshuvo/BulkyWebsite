using Microsoft.EntityFrameworkCore;
using RealEstate.model;

namespace RealEstate.data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Catagory>Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RealEstateDb;");
        }
    }
}
