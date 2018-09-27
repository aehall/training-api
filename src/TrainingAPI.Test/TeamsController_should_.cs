using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrainingApi.Controllers;
using TrainingApi.Models;
using Xunit;

namespace TrainingAPI.Test
{
    public class TeamsController_should_
    {
        [Fact]
        public void return_all_teams() // this ended up being an integration test since we are calling the database
        {
            // Arrange (Given)
            var testableRepository = new TestableEmployeesRepository();
            TeamsController myTeamsController = new TeamsController(testableRepository);

            var expectedTeams = new List<Team>
            {
                new Team { Id = 1, Name = "test" }
            };

            testableRepository.TeamsToReturn = expectedTeams;

            // Act (When)
            var response = myTeamsController.Get();

            // Assert (Then)
            Assert.IsType<OkObjectResult>(response); // could have used assert.equal= 200 but IActionResult is funky
            var actualTeams = (response as OkObjectResult).Value as List<Team>;
            Assert.Equal(expectedTeams, actualTeams);
        }
    }
}
