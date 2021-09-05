using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;
using WebApplication1.Model;
using WebApplication1.Repository;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("v1/account")]
    public class LoginController: ControllerBase
    {
        private readonly IUserService _service;

        public LoginController(IUserService service)
        {
            _service = service;
        }
        [Route("login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Login model)
        {
            var user = _service.Get(model.Nome, model.Senha);
            if (user == null) return NotFound(new { message = "Usuário ou senha inválidos" });
            var token = TokenService.GenerateToken(user);            
            return new { user = new User { Convenio = user.Convenio, Id = user.Id, Nome = user.Nome, Role = user.Role }, token = token };
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anonimo";


        [HttpGet]
        [Route("Authenticated")]
        [Authorize]
        public string Authenticated() => $"Autenticado { User.Identity.Name}";


        [HttpGet]
        [Route("Admin")]
        [Authorize("Admin")]
        public string Admin() => "Admin";

        [HttpGet]
        [Route("Master")]
        [Authorize("Master")]
        public string Master() => "Master";

        [HttpGet]
        [Route("User")]
        [Authorize("User")]
        public string Usuario() => "User";

    }
}
