using Microsoft.AspNetCore.Mvc;

using LolController = backend.App.Lols.Controller;
using PrimeController = backend.App.Primes.Controller;

namespace backend.App
{
    [Route("api/")]
    public class Controller
    {
        [HttpGet("test")]
        public string test () {
            return "tested";
        }
    }
}
