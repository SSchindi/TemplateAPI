using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITemplate.Models;
using WebAPITemplate.Services;

namespace WebAPITemplate.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private ITemplateRepository _IRepo { get; set; }

        public UsersController(ITemplateRepository _repo)
        {
            _IRepo = _repo;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _IRepo.GetAllUser();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            return BadRequest();
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser([FromRoute] int id, [FromBody] User user)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != user.UserId)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(user).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!UserExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return NoContent();
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //_context.Users.Add(user);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetUser", new { id = user.UserId }, user);
            return BadRequest();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //var user = await _context.Users.SingleOrDefaultAsync(m => m.UserId == id);
            //if (user == null)
            //{
            //    return NotFound();
            //}

            //_context.Users.Remove(user);
            //await _context.SaveChangesAsync();

            //return Ok(user);
            return BadRequest();
        }

        private bool UserExists(int id)
        {
            return _IRepo.UserExists(id);
        }
    }
}