using Microsoft.Extensions.DependencyInjection;
using MoneyCurrencyAPI.Application.Absraction;
using MoneyCurrencyAPI.Persistence.Concrete;


namespace MoneyCurrencyAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<ICurrencyService, CurrencyService>();
        }
    }
}
