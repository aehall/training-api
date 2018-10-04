using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Models;
using TrainingApi.Repositories;

namespace TrainingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Teams")]
    public class TeamsController : Controller
    {
        // Added when constructor below added//
        private IEmployeesRepository _employeesRepository;
        //Added for dependency injection //
        //This is a constructor //
        internal TeamsController(IEmployeesRepository employeesRepository) //IEmployeesRepository is a type employeesRepository is the name
        {
            _employeesRepository = employeesRepository;
        }

        // empty constructor required by web API doesn't take parms - used in production 
      
        public TeamsController():this(new EmployeesRepository()) 
        { }
        //Added for dependency injection to here//


        // GET: api/Teams
        [HttpGet]
        public IActionResult Get() //IActionResult is the response from the get
        {
            // var employeesRepository = new EmployeesRepository(); removed for unit testing - dependency injection
            // var teams = employeesRepository.GetAllTeams(); removed for unit testing - dependency injection
            var teams = _employeesRepository.GetAllTeams();
            return Ok(teams);
        }
        
        // GET: api/Teams/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var team = _employeesRepository.GetTeamById(id);
            return Ok(team);
        }
        
        // POST: api/Teams
        [HttpPost]
        public IActionResult Post([FromBody]Team team)
        {
            throw new NotImplementedException();
        }
        
        // PUT: api/Teams/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
