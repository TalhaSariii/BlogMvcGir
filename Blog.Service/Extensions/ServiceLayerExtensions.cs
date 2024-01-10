using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            services.AddScoped<IArticleService,ArticleService>();
            
            return services;
        }
    }
}
