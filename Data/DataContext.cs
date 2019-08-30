using Microsoft.EntityFrameworkCore;
using My.API.Models;

namespace My.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<User> Users { get; set; }
    }
}