using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(configure =>
            {
                configure.AddScoped<UserVoiceRepository>();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
