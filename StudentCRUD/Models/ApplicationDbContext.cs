using Microsoft.EntityFrameworkCore;

namespace StudentCRUD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
