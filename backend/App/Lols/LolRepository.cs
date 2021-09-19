using backend.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Lol = backend.Entities.Lol;

namespace backend.App.Lols
{
    public class LolRepository : BasicDbContextRepository<Lol> {}
    public class LolRepository2 : DbContext
    {
        public DbSet<Lol> Lols { get; set; }
    }
}