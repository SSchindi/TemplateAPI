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
        public User GetUser(int userId)
        {
            return _ctx.Users.First(u => u.UserId == userId);
        }

        public void SetUser(UserCreationDto user)
        {
            
        }
    }
}
