using Domain.Entities;
using Domain.Interfaces.Base;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;
using IOC;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddInfrastructureAutoMapper(builder.Configuration);





//builder.Services.AddScoped<IRepositoryBase<Uf>, RepositoryBase<Uf>>();



// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorOptions(options =>
{
    options.ViewLocationFormats.Add("/{0}.cshtml");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
