using Microsoft.EntityFrameworkCore;
using API.Entities;
namespace API.Data
{
    public class DataContext : DbContext{
        public DataContext(DbContextOptions option) : base(option)
        {}

        public DbSet<AppUser> User {get; set;}
        public object Users { get; internal set; }
    }
}