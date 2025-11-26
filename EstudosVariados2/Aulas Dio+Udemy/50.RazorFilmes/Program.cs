#region imports
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorFilmes.Data;
using Microsoft.AspNetCore.Routing;
using RazorFilmes.Models;
#endregion

#region builders
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorFilmesContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("RazorFilmesContext") ?? throw new InvalidOperationException("Connection string 'RazorFilmesContext' not found.")));

var app = builder.Build();

using(var scopo = app.Services.CreateScope())
{
    var services = scopo.ServiceProvider;
    SeedData.Initialize(services);
}
#endregion

#region ExceptionHandler
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
#endregion


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/routes", (IEnumerable<EndpointDataSource> sources) =>
{
    var routes = sources
        .SelectMany(s => s.Endpoints)
        .OfType<RouteEndpoint>()
        .Select(e => e.RoutePattern.RawText);

    return Results.Ok(routes);
});

app.Run();
