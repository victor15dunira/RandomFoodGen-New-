using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
       
        private AppSettings Configuration;

        public MergeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
         

            
            var CuisineService = $"{Configuration.CuisineServiceURL}/Cuisine";
            var CuisineResponseCall = await new HttpClient().GetStringAsync(CuisineService);

            var MealsService = $"{Configuration.MealsServiceURL}/Meals";
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
