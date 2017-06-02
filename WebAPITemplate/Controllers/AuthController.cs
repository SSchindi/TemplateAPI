using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebAPITemplate.Entities;
using WebAPITemplate.Models;
using WebAPITemplate.Services;

namespace WebAPITemplate.Controllers
{
    [Produces("application/json")]
    //[Route("api/Auth")]
    public class AuthController : Controller
    {
        private ITemplateRepository _ctx { get; set; }

        public AuthController(ITemplateRepository _repo)
        {
            _ctx = _repo;
        }

        // GET: api/Auth
        [HttpGet]
        public UserDto DoLogin(string username, string password)
        {
            User user = null;
            if (_ctx.DoLogin(username, password))
                 user = _ctx.GetAllUser().SingleOrDefault(u => u.Username == username);
            return Mapper.Map<UserDto>(user);

        }
    }
}