using Microsoft.EntityFrameworkCore;
using MyTestAPI.Model;

namespace MyTestAPI.Data
{
    public class StudentDbContext:DbContext
    {
       public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) {
        }
        public DbSet<Student> Students { get; set; }
    }
}
