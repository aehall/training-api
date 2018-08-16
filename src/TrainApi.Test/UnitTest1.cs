using System;
using TrainingApi;
using Xunit;

namespace TrainApi.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var repository = new EmployeesRepository();
            var result = repository.GetAllTeams();
        }
    }
}
