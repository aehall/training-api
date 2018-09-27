using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Repositories;

namespace TrainingApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Individuals")]
    public class IndividualsController : Controller
    {
        // GET: api/Individuals
        [HttpGet]
        public IActionResult Get()
        {
            // var employeesRepository = new EmployeesRepository(); removed for now - for unit test
            //var individuals = employeesRepository.GetAllIndividuals();
            return Ok();
        }

        // GET: api/Individuals/5 - this is a GET by id
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Individuals
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Individuals/5
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
