using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repository;
using WebApplication1.Services;

namespace WebApplication1.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services )
        {
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
