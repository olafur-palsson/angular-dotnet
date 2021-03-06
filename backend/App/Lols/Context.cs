using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Lol = backend.Entities.Lol;

namespace backend.App.Lols
{
    class Context : DbContext
    {
        public DbSet<Lol> Lols { get; set; }
        public string DbPath { get; private set; }

        public Context()
        {
            var folder = System.Environment.SpecialFolder.LocalApplicationData;
            var path = System.Environment.GetFolderPath(folder);
            this.DbPath = System.IO.Path.Join(path, "database.db");
        }

        public List<Lol> GetAll () {
            return (
                from lol in this.Lols
                select lol
            ).ToList();
        }
    }
}