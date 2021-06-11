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
        //Meals url https://localhost:44346/
        //letterurl https://localhost:44356/
        private IConfiguration Configuration;

        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        [HttpGet]

        public async Task<IActionResult> Get()
        {
            // var MealsService = "https://localhost:44346/Meals";
            var MealsService = $"{Configuration["MealsServiceURL"]}/Meals";
            var MealsResponseCall = await new HttpClient().GetStringAsync(MealsService);


            // var CuisineService = "https://localhost:44356/Cuisine";
            var CuisineService = $"{Configuration["CuisineServiceURL"]}/numbers";
            var CuisineResponseCall = await new HttpClient().GetStringAsync(CuisineService);

            var mergeResponse = $"{MealsResponseCall}{CuisineResponseCall}";
            return Ok(mergeResponse);
        }
        }
}
