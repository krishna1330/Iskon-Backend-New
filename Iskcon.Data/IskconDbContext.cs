using Iskcon.Business;
using Microsoft.EntityFrameworkCore;

namespace Iskcon.Data
{
    public class IskconDbContext : DbContext
    {
        public IskconDbContext(DbContextOptions<IskconDbContext> options) : base(options) { }

        public DbSet<RegisteredMembers> RegisteredMembers { get; set; }

    }
}
