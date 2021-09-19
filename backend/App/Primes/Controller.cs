using System.Collections.Generic;
using Console = System.Console;

using Microsoft.AspNetCore.Mvc;

using PrimeService = Prime.Services.PrimeService;


namespace backend.App.Primes
{
    [Route("api/primes/")]
    public class Controller
    {
        [HttpGet("getPrimes/{nPrimes}")]
        public List<int> GetPrimes(int nPrimes)
        {
            var primeService = new PrimeService();
            var list = new List<int> {};
            var i = 2;
            while (list.Count < nPrimes) {
                Console.WriteLine($"{list.Count} {i}");
                if (primeService.IsPrime(i)) {
                    list.Add(i);
                }
                i++;
            }
            return list;
        }
    }
}