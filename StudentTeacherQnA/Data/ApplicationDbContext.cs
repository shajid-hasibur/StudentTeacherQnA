using Microsoft.EntityFrameworkCore;
using StudentTeacherQnA.Models;

namespace StudentTeacherQnA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
