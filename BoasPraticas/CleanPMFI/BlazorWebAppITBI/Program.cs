using BlazorWebAppITBI.Components;
using Microsoft.FluentUI.AspNetCore.Components;
using IOC;
using BlazorWebAppITBI.Model;
using Microsoft.AspNetCore.Authentication;
using Domain.Entities.NFSEDB;
using System.Net.Http.Headers;
using BlazorWebAppITBI.Uteis;

var builder = WebApplication.CreateBuilder(args);


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
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//builder.Services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<TribEdificacoesValidator>());
builder.Services.AddHttpClient();
builder.Services.AddFluentUIComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
app.Run();
