using Microsoft.EntityFrameworkCore;
using Lol = backend.Entities.Lol;

namespace backend.App.Lols
{
    public class Context : DbContext
    {
        public DbSet<Lol> Lols { get; set; }
    }
}