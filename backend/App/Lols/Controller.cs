using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lol = backend.Entities.Lol;

namespace backend.App.Lols
{
    [Route("api/lols/")]
    public class LolController : Controller
    {
        private readonly Context _db = new Context();

        [HttpGet("getEntities/")]
        public List<Lol> GetAll (
        ) {
            return this._db.GetAll();
        }

        public Lol CreateOne()
        {
            return this.Create(Lol.CreateLol());
        }

        private Lol Create (Lol lol) {
            var newLol = this._db.Lols.Add(lol);
            this._db.SaveChanges();
            return newLol.Entity;
        }
    }
}
