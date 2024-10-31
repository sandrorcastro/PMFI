using BlazorWebAppITBI.Components;
using BlazorWebAppITBI.Components.Account;
using Microsoft.FluentUI.AspNetCore.Components;
using IOC;
using BlazorWebAppITBI.Model;
using Microsoft.AspNetCore.Authentication;
using Domain.Entities.NFSEDB;
using System.Net.Http.Headers;
using BlazorWebAppITBI.Uteis;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlazorWebAppITBI.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection-DBProsiga-Auth") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();





builder.Services.AddServerSideBlazor();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
//builder.Services.AddSingleton<clsGeraCrystalPDF>();
builder.Services.AddScoped<ReportService>();


builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddInfrastructureAutoMapper(builder.Configuration);
//builder.Services.AddScoped<BlazorWebAppITBI.Uteis.AuthenticationService>();
//builder.Services.AddHttpClient<AuthenticationService>(client =>
//{
//  client.BaseAddress = new Uri("http://www2.pmfi.pr.gov.br/");
//  client.DefaultRequestHeaders.Accept.Clear();
//  client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
//});




// Add services to the container.
/////builder.Services.AddRazorComponents()
   ///// .AddInteractiveServerComponents();
//builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<TribEdificacoesValidator>());
builder.Services.AddHttpClient();
builder.Services.AddFluentUIComponents();
//builder.Services.AddDataGridEntityFrameworkAdapter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
//adicionei aqui
//app.UseRouting();
//app.MapBlazorHub();
////app.MapFallbackToPage("/_Host");
//
app.UseAntiforgery();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();
app.Run();
