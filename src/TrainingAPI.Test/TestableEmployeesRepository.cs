using System.Collections.Generic;
using TrainingApi.Models;
using TrainingApi.Repositories;

namespace TrainingAPI.Test
{
    public class TestableEmployeesRepository : IEmployeesRepository
    {
        public List<Team> TeamsToReturn { get; set; }

        public int CreateTeam(string teamName)
        {
            throw new System.NotImplementedException();
        }

        public List<Individual> GetAllIndividuals()
        {
            throw new System.NotImplementedException();
        }

        public List<Team> GetAllTeams()
        {
            return TeamsToReturn;
        }

        public Team GetTeamById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
