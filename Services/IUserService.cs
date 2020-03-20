using System.Collections.Generic;
using WebApi.Entities;

namespace WebApi.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Register(User user);
        void ChangePassword(string email);
    }
}