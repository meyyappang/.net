using API.Context;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpolyeeController : ControllerBase
    {

        private readonly CRUDContext _CRUDContext;

        public EmpolyeeController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }


        // GET: api/<EmpolyeeController>
        [HttpGet]
        public IEnumerable<Empolyee> Get()
        {
            return _CRUDContext.Empolyees;
        }

        // GET api/<EmpolyeeController>/5
        [HttpGet("{id}")]
        public Empolyee Get(int id)
        {
            return _CRUDContext.Empolyees.SingleOrDefault(x => x.EmployeeId == id);
        }

        // POST api/<EmpolyeeController>
        [HttpPost]
        public void Post([FromBody] Empolyee empolyee)
        {
            _CRUDContext.Empolyees.Add(empolyee);
            _CRUDContext.SaveChanges();
        }

        // PUT api/<EmpolyeeController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Empolyee empolyee)
        {
            _CRUDContext.Empolyees.Update(empolyee);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<EmpolyeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Empolyees.FirstOrDefault(x => x.EmployeeId == id);
            if(item != null)
            {
                _CRUDContext.Empolyees.Remove(item);
                _CRUDContext.SaveChanges();
            }

        }
    }
}
