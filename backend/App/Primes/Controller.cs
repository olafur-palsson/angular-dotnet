using System.Collections.Generic;
using System.Linq;
using Console = System.Console;

using Microsoft.AspNetCore.Mvc;

using Entities = backend.Entities;


namespace backend.App.Primes
{
    [Route("api/primes/")]
    public class Controller
    {
        [HttpGet("test")]
        public string Test()
        {
            return "tested";
        }
        [HttpGet("getPrimes/{nPrimes}")]
        public List<int> GetPrimes(int nPrimes)
        {
            var list = new List<int> {};
            var i = 2;
            while (list.Count < nPrimes) {
                Console.WriteLine($"{list.Count} {i}");
                if (Entities.Primes.IsPrime(i)) {
                    list.Add(i);
                }
                i++;
            }
            return list;
        }
    }
}