using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Repository
{
    public class UserRepository : IUserRepository
    {

        private IEnumerable<User> users;

        public UserRepository()
        {
            users = CreateUserList();
        }

        public User Get(string nome, string password)
        {
            return users.FirstOrDefault(x => x.Nome.ToLower() == nome.ToLower() && x.Senha == password);
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }

        public IEnumerable<User> GetByConvenio(int convenio)
        {
            return users.Where(x => x.Convenio == convenio).ToList();
        }

        public void Insert(User user) => users.ToList().Add(user);

        private IEnumerable<User> CreateUserList()
        {
            return new List<User> {
                new User { Id = 1, Nome = "Fernando", Role = "Admin", Senha = "teste", Convenio = 1 },
                new User { Id = 2, Nome = "Giovana", Role = "Master", Senha = "teste2", Convenio = 2 },
                new User { Id = 3, Nome = "Bia", Role = "Master", Senha = "teste3", Convenio = 3 },
                new User { Id = 4, Nome = "User1", Role = "User", Senha = "teste3", Convenio = 2 },
                new User { Id = 5, Nome = "User2", Role = "User", Senha = "teste3", Convenio = 1 },
                new User { Id = 6, Nome = "User3", Role = "User", Senha = "teste3", Convenio = 1 },
                new User { Id = 7, Nome = "User4", Role = "User", Senha = "teste3", Convenio = 2 },
                new User { Id = 8, Nome = "User5", Role = "User", Senha = "teste3", Convenio = 3 },
            };
        }
    }
}
