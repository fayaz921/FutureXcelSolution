using FutureXcel.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureXcel.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

       public DbSet<Testitem> Testitems { get; set; }
    }
}
