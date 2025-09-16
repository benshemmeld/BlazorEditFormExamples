using BlazorEditFormExamples.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorEditFormExamples
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");    
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddValidatorsFromAssemblyContaining<ContactAddressValidator>(ServiceLifetime.Scoped);
            builder.Services.AddValidatorsFromAssemblyContaining<ContactBaseValidator>(ServiceLifetime.Scoped);
            builder.Services.AddValidatorsFromAssemblyContaining<ContactPersonValidator>(ServiceLifetime.Scoped);
            builder.Services.AddValidatorsFromAssemblyContaining<ContactOrganisationValidator>(ServiceLifetime.Scoped);
            builder.Services.AddValidatorsFromAssemblyContaining<FormContactModelValidator>(ServiceLifetime.Scoped);

            await builder.Build().RunAsync();
        }
    }
}
