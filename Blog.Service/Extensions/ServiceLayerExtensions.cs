﻿using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Blog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            var assembly=Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService,ArticleService>();

            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
