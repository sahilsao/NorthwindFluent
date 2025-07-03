<<<<<<< HEAD
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;
using Northwind.Client;
=======
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;
using Northwind.Client.Components;
using Northwind.Client.Sessions;
using Northwind.Client.Context;
>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

<<<<<<< HEAD
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
=======
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<CustomerSessions>();

builder.Services.AddDbContextFactory<DbContextNorthwind>(options =>
    options.UseSqlServer("DefaultConnection"));

>>>>>>> 27e4851e4715ee1fbe6428402f3a35d91cc9639f
builder.Services.AddFluentUIComponents();

await builder.Build().RunAsync();
