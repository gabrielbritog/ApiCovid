using Data.Repository;
using Domain.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureDepRepository
    {
        public static void ConfigureRepository(IServiceCollection serviceCollection )
        {
            serviceCollection.AddScoped<IRepository, Repository>(); 
        }
    }
}
