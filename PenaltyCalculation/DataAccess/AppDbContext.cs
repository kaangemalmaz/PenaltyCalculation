using Microsoft.EntityFrameworkCore;
using PenaltyCalculation.Models;

namespace PenaltyCalculation.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Weekend> Weekends { get; set; }
    }
}
