using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Meals.Web.Tests.Controllers
{
   public class MergeControllerTest
    {

        private AppSettings appSettings = new AppSettings()
        {

            CuisineServiceURL = "https://cuisineapp.azurewebsites.net/",
            MealsServiceURL= "https://mealsapp.azurewebsites.net/"

        };

        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>(); //MOCK of the merge controller directed from Appsettings azure URLS
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object); //injection of the mocked mergecontroller
            var mergeControllerResult = await mergeController.Get();

            Assert.NotNull(mergeControllerResult);
            Assert.IsType<OkObjectResult>(mergeControllerResult);



        }

    }
}
