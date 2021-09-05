using System.Collections.Generic;
using WebApplication1.Model;

namespace WebApplication1.Services
{
    public interface IUserService
    {
        void CreateUser(User user);
        User Get(string nome, string senha);
        IEnumerable<User> GetAll();
        IEnumerable<User> GetByConvenio(int convenio);
    }
}