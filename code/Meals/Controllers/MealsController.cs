using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Meals.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealsController : ControllerBase
    {

        public string[] Meal = new[]
        {
            "Lasagna", "Beef Chili", "Fried Chicken Wings", "Spaghetti and Tomato Sauce", "Fajitas", "Macaroni and Cheese", "Slow-Cooked Beef Stew", "Crab Cakes", "Chicken and Dumplings", "", "Chicken Pie", "Roasted Chicken and Vegetables"
        };

        [HttpGet] //the method serves a get request
        public IActionResult GetMeal()
        {
            var rnd = new Random();   //variable named rnd, which stores random variables 
            var rndMeal = Meal[rnd.Next(0, Meal.Length)]; //the random function, selects a random string from the array Cuisine.

            //Console.WriteLine($"Cusine:{rndCuisine}");

            return Ok(rndMeal);

        }

    }
}
