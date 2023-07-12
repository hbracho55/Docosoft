using Docosoft.Models;
using Microsoft.EntityFrameworkCore;

namespace Docosoft.Data
{
    public class UserDbContext : DbContext
    {

        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }

}
