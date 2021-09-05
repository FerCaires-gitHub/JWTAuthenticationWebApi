using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Repository;

namespace WebApplication1.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public void CreateUser(User user)
        {
            _repository.Insert(user);
        }

        public User Get(string nome, string senha)
        {
            return _repository.Get(nome, senha);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<User> GetByConvenio(int convenio)
        {
            return _repository.GetByConvenio(convenio);
        }
    }
}
