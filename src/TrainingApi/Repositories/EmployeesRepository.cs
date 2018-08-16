using System.Collections.Generic;
using System.Data.Common;
using TrainingApi.Models;
using Npgsql;
using System.Data;

namespace TrainingApi.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        public List<Individual> GetAllIndividuals()
        {
            var connection = GetDatabaseConnection();
            connection.Open();

            var individuals = new List<Individual>();

            using (var command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "get_all_individuals";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            individuals.Add(new Individual
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                TeamId = reader.GetInt32(reader.GetOrdinal("teamId")),
                                FirstName = reader.GetString(reader.GetOrdinal("firstName")),
                                LastName = reader.GetString(reader.GetOrdinal("lastName")),
                                Title = reader.GetString(reader.GetOrdinal("title")),
                                EmailAddress = reader.GetString(reader.GetOrdinal("emailAddress")),
                            });
                        }
                    }
                }
            }

            return individuals;
        }

        public List<Team> GetAllTeams()
        {
            var connection = GetDatabaseConnection();
            connection.Open();

            var teams = new List<Team>();

            using (var command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "get_all_teams";

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            teams.Add(new Team
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                            });
                        }
                    }
                }
            }

            return teams;
        }

        private NpgsqlConnection GetDatabaseConnection()
        {
            var connectionStringBuilder = new DbConnectionStringBuilder
            {
                { "Server", "localhost" },
                { "Port", 5432 },
                { "User Id", "postgres" },
                { "Password", "password" },
                { "Database", "Employees" }
            };

            return new NpgsqlConnection { ConnectionString = connectionStringBuilder.ConnectionString };
        }
    }
}
