using System.Collections.Generic;
using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public interface IUserRepository
    {
        User Get(string nome, string password);
        void Insert(User user);
        IEnumerable<User> GetAll();

        IEnumerable<User> GetByConvenio(int convenio);
    }
}