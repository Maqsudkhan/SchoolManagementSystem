using Grade.Application.Abstractions;
using Grade.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Infrastructure
{
    public static class GradeInfrastructureDependencyInjection
    {
        public static IServiceCollection AddGradeInfrastructureDependencyInjection(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<IGradeDbContext, GradeDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("GradeConnectionString"));
            });
            return services;
        }
    }
}
