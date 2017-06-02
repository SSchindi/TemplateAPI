using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITemplate.Entities;
using WebAPITemplate.Models;

namespace WebAPITemplate.Services
{
    public class TemplateRepository : ITemplateRepository
    {
        private TemplateContext _ctx;
        public TemplateRepository(TemplateContext ctx)
        {
            _ctx = ctx;
        }

        public List<User> GetAllUser()
        {
            return _ctx.Users.ToList();
        }

        public bool UserExists(int userId)
        {
            var allUsers = _ctx.Users.ToList();
            if (allUsers.Count == 0)
                return false;

            return allUsers.Exists(u => u.UserId == userId);
        }

        public bool DoLogin(string username, string password)
        {
            User user = _ctx.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
                return false;
            if (user.Password == password)
                return true;
            return false;
        }


        public User GetUser(int userId)
        {
            return _ctx.Users.First(u => u.UserId == userId);
        }

        public void SetUser(UserCreationDto user)
        {
            
        }
    }
}
