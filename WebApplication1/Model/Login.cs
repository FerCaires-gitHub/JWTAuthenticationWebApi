using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class Login
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
