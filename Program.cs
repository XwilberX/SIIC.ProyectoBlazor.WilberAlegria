using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SIIC.ProyectoBlazor.WilberAlegria.ApiClient.ApiWebClient;
using SIIC.ProyectoBlazor.WilberAlegria.BL;
using Blazored.Modal;

namespace SIIC.ProyectoBlazor.WilberAlegria
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddTransient(s => new EmpresasApi("https://tiendablazor.azurewebsites.net"));
            builder.Services.AddTransient<EmpresasBL>();

            builder.Services.AddBlazoredModal();

            await builder.Build().RunAsync();
        }
    }
}
