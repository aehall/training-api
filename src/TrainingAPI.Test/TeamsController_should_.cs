using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using TrainingApi.Controllers;
using TrainingApi.Models;
using TrainingApi.Repositories;
using Xunit;

namespace TrainingAPI.Test
{
    public class TeamsController_should_
    {
        [Fact]
        public void return_all_teams() // this ended up being an integration test since we are calling the database
        {
            // Arrange (Given)
            var expectedTeams = new List<Team>
            {
                new Team { Id = 1, Name = "test" }
            };

            // with hand-rolled mock
            //var repositoryMock = new TestableEmployeesRepository();
            //repositoryMock.TeamsToReturn = expectedTeams;

            // with Moq
            var repositoryMock = new Mock<IEmployeesRepository>();
            repositoryMock.Setup(repository => repository
                          .GetAllTeams())
                          .Returns(expectedTeams);

            var myTeamsController = new TeamsController(repositoryMock.Object);

            // Act (When)
            var response = myTeamsController.Get();

            // Assert (Then)
            Assert.IsType<OkObjectResult>(response); // could have used assert.equal= 200 but IActionResult is funky
            var actualTeams = (response as OkObjectResult).Value as List<Team>;
            Assert.Equal(expectedTeams, actualTeams);
        }

        // Example of Moq's .Throws() functionality
        //[Fact]
        //public void return_500_if_repository_throws_error()
        //{
        //    var repositoryMock = new Mock<IEmployeesRepository>();
        //    repositoryMock.Setup(repository => repository
        //                  .GetAllTeams())
        //                  .Throws(new System.Exception("I failed!"));

        //    var myTeamsController = new TeamsController(repositoryMock.Object);

        //    var response = myTeamsController.Get();
        //}

        [Fact]
        public void get_team_by_id()
        {
            // Arrange (Given)
            var expectedTeam = new Team { Id = 1, Name = "test" };

            var repositoryMock = new Mock<IEmployeesRepository>();
            repositoryMock.Setup(repository => repository
                          .GetTeamById(expectedTeam.Id))
                          .Returns(expectedTeam);

            var myTeamsController = new TeamsController(repositoryMock.Object);

            // Act (When)
            var response = myTeamsController.Get(expectedTeam.Id);

            // Assert (Then)
            Assert.IsType<OkObjectResult>(response); // could have used assert.equal= 200 but IActionResult is funky
            var actualTeams = (response as OkObjectResult).Value as Team;
            Assert.Equal(expectedTeam, actualTeams);
        }
    }
}
