using System.Collections.Generic;
using System.Linq;
using Lol = backend.Entities.Lol;

namespace backend.App.Lols
{
    public class Logic
    {
        private readonly LolRepository _db = new LolRepository();

        public Lol CreateOne (Lol lol) {
            var newLol = this._db.Lols.Add(lol);
            this._db.SaveChanges();
            return newLol.Entity;
        }

        public Lol RandomLol () {
            return new Lol {
                Name = "Name",
                Text = "Some text bruh",
                Amount = 69,
                YoloId = null
            };
        }

        public List<Lol> GetAll () {
            var result =
                from lol in this._db.Lols
                select lol;
            return result.ToList();
        }
    }
}