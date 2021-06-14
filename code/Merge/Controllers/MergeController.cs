using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        //Meals url 
        //letterurl 
        private IConfiguration Configuration;

        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        [HttpGet]

        public async Task<IActionResult> Get()
        {
         

            // var CuisineService = "http://localhost:35840/Cuisine";
            var CuisineService = $"{Configuration["CuisineServiceURL"]}/Cuisine";
            var CuisineResponseCall = await new HttpClient().GetStringAsync(CuisineService);

            



  // var MealsService = "http://localhost:2861/Meals";
            var MealsService = $"{Configuration["MealsServiceURL"]}/Meals";
            var MealsResponseCall = await new HttpClient().GetStringAsync(MealsService);

           // if (CuisineResponseCall == "American" || MealsResponseCall == "Macaroni and Cheese")
            {

            }


           // if (CuisineResponseCall == "American")

              //  switch (Meal)
                {


                }

    


            var mergeResponse = $"{CuisineResponseCall} {MealsResponseCall} ";
            return Ok(mergeResponse);
        }
        }
}
