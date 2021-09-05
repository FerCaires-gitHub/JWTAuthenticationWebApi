using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public int Convenio { get; set; }
    }
}
