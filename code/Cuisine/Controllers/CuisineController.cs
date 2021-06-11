using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cuisine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuisineController : ControllerBase
    {
        public string[] Cuisine = new[]
        {
            "American", "Caribbean", "Vietnamese", "Korean", "Indian", "Japanese", "Spanish", "Mediterranean", "Lebanese", "French", "South African"
        };

        [HttpGet] //the method serves a get request
        public IActionResult GetCuisine()
        {
            var rnd = new Random();   //variable named rnd, which stores random variables 
            var rndCuisine = Cuisine[rnd.Next(0, Cuisine.Length)]; //the random function, selects a random string from the array Cuisine.

            //Console.WriteLine($"Cusine:{rndCuisine}");

            return Ok(rndCuisine);

        }

    }
}
