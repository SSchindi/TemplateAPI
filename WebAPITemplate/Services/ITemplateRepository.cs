using System.Collections.Generic;
using WebAPITemplate.Entities;
using WebAPITemplate.Models;

namespace WebAPITemplate.Services
{
    public interface ITemplateRepository
    {
        User GetUser(int userId);
        void SetUser(UserCreationDto user);
        List<User> GetAllUser();
        bool UserExists(int userId);
        bool DoLogin(string username, string password);
    }
}
