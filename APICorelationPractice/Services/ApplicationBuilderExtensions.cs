using APICorelationPractice.Helpers;
using Microsoft.AspNetCore.Builder;

namespace APICorelationPractice.Services
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddCorrelationIdMiddleware(this IApplicationBuilder application) =>
             application.UseMiddleware<CorrelationIdMiddleware>();
    }
}
