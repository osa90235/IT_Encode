// See https://aka.ms/new-console-template for more information
using IT_Encode;
using IT_Encode.Interface;
using IT_Encode.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost _Host = Host.CreateDefaultBuilder()
    .ConfigureServices(services => services.AddSingleton<IMain, Application>())
    .ConfigureServices(services => services.AddSingleton<IEncode, StrEncode>())
    .Build();

var app = _Host.Services.GetRequiredService<IMain>();

app.Run();