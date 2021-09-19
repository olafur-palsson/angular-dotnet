using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Lol = backend.Entities.Lol;


namespace backend.App.Lols
{
    [Route("api/lols/")]
    public class LolController
    {
        private readonly Logic _logic = new Logic();

        [HttpGet("getEntities/")]
        public List<Lol> GetEntities(int nPrimes)
        {
            return _logic.GetAll();
        }

        [HttpGet("createOne/")]
        public Lol CreateOne(int nPrimes)
        {
            var lol = _logic.RandomLol();
            return _logic.CreateOne(lol);
        }
    }
}
