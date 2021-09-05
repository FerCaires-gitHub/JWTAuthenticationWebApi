using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Settings
    {
        public static string Secret = "25ffe12b50d032ac30334752100cd9832f91110fe5c504062ba9f1938a6bd184";

        public static string CreateHash()
        {
            using (var hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes("berranteiro matado de onca"));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
