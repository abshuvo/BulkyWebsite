using Microsoft.EntityFrameworkCore;
using MyFirstMVC.Models;

namespace MyFirstMVC.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext>options) : base(options)
        
       {
        }
        public DbSet<Customer>Customers { get; set; }
        
    }
}
