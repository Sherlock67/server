using APIServer.Model;
using Microsoft.EntityFrameworkCore;

namespace APIServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }


    }
}
