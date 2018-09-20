using Microsoft.AspNetCore.Mvc;
using System;
using TrainingApi.Controllers;
using Xunit;

namespace TrainingAPI.Test
{
    public class TeamsController_should_
    {
        [Fact]
        public void return_all_teams() // this ended up being an integration test since we are calling the database
        {
            TeamsController myTeamsController = new TeamsController();
            myTeamsController.Get();
            var response = myTeamsController.Get();
            Assert.IsType<OkObjectResult>(response); // could have used assert.equal= 200 but IActionResult is funky
        }
    }
}
