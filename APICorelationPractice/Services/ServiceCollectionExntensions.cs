using APICorelationPractice.Configurations.Interfaces;

namespace APICorelationPractice.Services
{
    public static class ServiceCollectionExntensions
    {
        public static IServiceCollection AddCorrelationIdManager(this IServiceCollection services)
        {
            services.AddScoped<ICorrelationIdGenerator,CorrelationIdGenerator>();

            return services;
        }
    }
}
