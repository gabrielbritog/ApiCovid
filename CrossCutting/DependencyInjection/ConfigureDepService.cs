using Data.Repository;
using Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureDepService
    {
        public static void ConfigureService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IService, ListService>();
        }
    }
}
