using System.Collections.Generic;
using Console = System.Console;
using Microsoft.AspNetCore.Mvc;

using Lol = backend.Entities.Lol;

namespace backend.App.Lols
{
    [Route("api/lols/")]
    public class Controller
    {
        private Context db = new Context();

        [HttpGet("getEntities/")]
        public List<Lol> GetAll () {
            return this.db.GetAll();
        }

        [HttpGet("createOne/")]
        public Lol CreateOne(int nPrimes)
        {
            return this.Create(Lol.CreateLol());
        }

        private Lol Create (Lol lol) {
            var newLol = this.db.Lols.Add(lol);
            this.db.SaveChanges();
            return newLol.Entity;
        }
    }
}
