using Microsoft.EntityFrameworkCore;
//using PMFI.WebMVC.Context;
//using PMFI.Infra.Context;
using PMFI.IOC;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddAutoMapperConfig();


////var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'ContextoAplicacaoConnection' not found.");

///builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
///
//builder.Services.AddDbContextFactory<ApplicationDbContext>(options => options.UseSqlServer(connectionString));





builder.Services.AddControllersWithViews();

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
