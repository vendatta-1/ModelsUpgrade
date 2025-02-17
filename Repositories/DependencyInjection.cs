using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;

namespace Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectRepositories(this IServiceCollection service, IConfiguration configuration)
        {

            service.AddScoped(typeof(IRepository<>), typeof());




            return service;

        }
    }
}
