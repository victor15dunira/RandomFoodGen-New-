using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Moq;
using Cuisine.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Meals.Web.Tests.Controllers
{
    public class CuisineControllerTest
    {

        [Fact]

        public void GetTest()
        {
            CuisineController cuisineController = new CuisineController();
            var cuisineControllerResult = cuisineController.GetCuisine();

            Assert.NotNull(cuisineControllerResult);
            Assert.IsType<ActionResult<string>>(cuisineControllerResult);



        }


    }
}
