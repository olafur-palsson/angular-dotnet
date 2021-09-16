using System.Linq;
using System.Collections.Generic;

using Lol = backend.Entities.Lol;

namespace backend.App.Lols
{
    public class Logic
    {
        private Context db = new Context();

        public Lol CreateOne (Lol lol) {
            var newLol = this.db.Lols.Add(lol);
            this.db.SaveChanges();
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
                from lol in this.db.Lols
                select lol;
            return result.ToList();
        }
    }
}