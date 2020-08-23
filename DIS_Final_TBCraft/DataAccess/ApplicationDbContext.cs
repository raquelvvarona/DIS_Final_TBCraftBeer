using Microsoft.EntityFrameworkCore;
using DIS_Final_TBCraft.Models;

namespace DIS_Final_TBCraft.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Beer> Beer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
    }

}