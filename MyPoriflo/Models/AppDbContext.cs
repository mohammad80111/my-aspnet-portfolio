using Microsoft.EntityFrameworkCore;

namespace MyPoriflo.Models
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }


        public DbSet<Contact> contacts { get; set; }    

    }
}
