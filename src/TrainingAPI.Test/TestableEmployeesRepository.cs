using System.Collections.Generic;
using TrainingApi.Models;
using TrainingApi.Repositories;

namespace TrainingAPI.Test
{
    public class TestableEmployeesRepository : IEmployeesRepository
    {
        public List<Team> TeamsToReturn { get; set; }

        public List<Individual> GetAllIndividuals()
        {
            throw new System.NotImplementedException();
        }

        public List<Team> GetAllTeams()
        {
            return TeamsToReturn;
        }
    }
}
