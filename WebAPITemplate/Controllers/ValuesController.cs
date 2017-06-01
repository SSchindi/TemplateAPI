using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITemplate.Entities;
using WebAPITemplate.Models;
using WebAPITemplate.Services;

namespace WebAPITemplate.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ITemplateRepository _repo { get; set; }

        public ValuesController(ITemplateRepository ctx)
        {
            _repo = ctx;
        }
        // GET api/values
        [HttpGet]
        public List<User> Get()
        {
            List<User> data;


            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0) return BadRequest();
            var user = _repo.GetUser(id);
            if (user == null) return NotFound();
            return Ok(Mapper.Map<UserDto>(user));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] UserCreationDto value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
