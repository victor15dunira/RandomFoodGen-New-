using Meals.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Meals.Web.Tests.Controllers
{
   public class MealsControllerTest
     
    {

        [Fact]

        public void GetTest()
        {
            MealsController mealsController = new MealsController();
            var MealsControllerResult = mealsController.GetMeal();

            Assert.NotNull(MealsControllerResult);


            Assert.IsType<OkObjectResult>(MealsControllerResult);



        }


    }
}

