using System.Security.AccessControl;
using System.Collections.Generic;
using Console = System.Console;

using Microsoft.AspNetCore.Mvc;

using Lol = backend.Entities.Lol;


namespace backend.App.Lols
{
    [Route("api/lols/")]
    public class Controller
    {
        private Logic logic = new Logic();

        [HttpGet("getEntities/")]
        public List<Lol> GetEntities(int nPrimes)
        {
            return this.logic.GetAll();
        }

        [HttpGet("createOne/")]
        public Lol CreateOne(int nPrimes)
        {
            var lol = this.logic.RandomLol();
            return this.logic.CreateOne(lol);
        }
    }
}
