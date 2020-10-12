using System.Threading.Tasks;
using oct2020.Models.TokenAuth;
using oct2020.Web.Controllers;
using Shouldly;
using Xunit;

namespace oct2020.Web.Tests.Controllers
{
    public class HomeController_Tests: oct2020WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}