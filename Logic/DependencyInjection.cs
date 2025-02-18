using Logic.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace Logic
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectLogic(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationProfile).Assembly);
            return services;
        }
    }
}
