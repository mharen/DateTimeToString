using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<ILanguageProvider, JsLanguageProvider>();
builder.Services.AddScoped<ITimeZoneProvider, JsTimeZoneProvider>();
builder.Services.AddScoped<INavigationProvider, JsNavigationProvider>();

await builder.Build().RunAsync();
