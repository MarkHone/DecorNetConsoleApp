// See https://aka.ms/new-console-template for more information
using Decor;
using DecorNetConsoleApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices((_, services) =>
    {
        services.AddScoped<ITestService, TestService>()
            .AddTransient<LoggingDecorator>()
            .Decorate<ITestService>();
    })
    .Build();

Console.WriteLine("Hello, World!");
host.Services.GetRequiredService<ITestService>().DoWork();
