using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("v1/Users")]
    public class UserController:ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("Create")]
        [Authorize("Admin")]
        public IActionResult Create([FromBody] User user)
        {
            try
            {
                _service.CreateUser(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("Get")]
        [Authorize("Master")]
        public IActionResult GetAll()
        {
            try
            {
                var users = _service.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet]
        [Route("GetByConvenio")]
        [Authorize("Master")]
        public IActionResult GetByConvenio()
        {
            try
            {
                var convenio =Convert.ToInt32(User.Claims.FirstOrDefault(x => x.Type == "Convenio").Value);
                var users = _service.GetByConvenio(convenio);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
