using WebAPITemplate.Entities;
using WebAPITemplate.Models;

namespace WebAPITemplate.Services
{
    public interface ITemplateRepository
    {
        User GetUser(int userId);
        void SetUser(UserCreationDto user);
    }
}
