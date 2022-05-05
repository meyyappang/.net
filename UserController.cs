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
    public class UserController : ControllerBase

    {
        private readonly CRUDContext _CRUDContext;

        public UserController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }



        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _CRUDContext.Users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _CRUDContext.Users.SingleOrDefault(x => x.EmployeeId == id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _CRUDContext.Users.Add(user);
            _CRUDContext.SaveChanges();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] User user)
        {
            _CRUDContext.Users.Update(user);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Users.FirstOrDefault(x => x.EmployeeId == id);
            if(item != null)
            {
                _CRUDContext.Users.Remove(item);
                _CRUDContext.SaveChanges();
            }
          
        }
    }
}
