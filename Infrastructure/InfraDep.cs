
using Data.Models;
using Infrastructure.DbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class InfraDep
    {

        public static IServiceCollection AddDbDep(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<ApplicationContext>(option =>
            option.UseLazyLoadingProxies()
            .UseSqlServer(configuration["ConnctionString"]));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();

            return services;
        }
    }
}
