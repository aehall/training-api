using System.Collections.Generic;
using TrainingApi.Models;

namespace TrainingApi.Repositories
{
    public interface IEmployeesRepository
    {
        List<Individual> GetAllIndividuals();
        List<Team> GetAllTeams();
        Team GetTeamById(int id);
        int CreateTeam(string teamName);
    }
}
