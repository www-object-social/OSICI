using InterConnectingInfo.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
//using OSICI.Product;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("WebSite.Server.Domain", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebSite.Server.Domain"));
//builder.Services.AddPI(Name.InterConnectingInfo, OSICI.Product.Type.Browser);
await builder.Build().RunAsync();
