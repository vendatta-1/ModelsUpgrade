using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModelsUpgrade.Data;
using Repositories.Implementations;
using Repositories.Interfaces;

namespace Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectRepositories(this IServiceCollection service, IConfiguration configuration)
        {

            service.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            service.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });



            return service;

        }
    }
}
