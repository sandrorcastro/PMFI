
//using Infra.Context;
using Infra.Context;
using Infra.EntityConfig;
using IOC;
using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC.MappingConfig;

//using MVC.MappingConfig;


namespace MVC
{
    public class Program
    {
        public static void Main(string[] args) 

        {
            var builder = WebApplication.CreateBuilder(args);
            //var connectionString = builder.Configuration.GetConnectionString("ContextoAplicacaoConnection") ?? throw new InvalidOperationException("Connection string 'ContextoAplicacaoConnection' not found.");
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'ContextoAplicacaoConnection' not found.");

            //builder.Services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(connectionString));
            builder.Services.AddDbContextFactory<ContextoAplicacao>(options => options.UseSqlServer(connectionString));
            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ContextoAplicacao>().AddSignInManager<SignInManager<ApplicationUser>>().AddDefaultUI();
            builder.Services.AddScoped<SignInManager<ApplicationUser>>();
            // outras configura��es

            builder.Services.AddInfrastructure(builder.Configuration);
            // builder.Services.Configure<SendinBlueSettings>(builder.Configuration.GetSection("SendinBlueSettings"));
            //builder.Services.AddSingleton<IEmailService, SendinBlueService>();
            //builder.Services.AddSingleton<IWhatsappService, TwilioWhatsappService>();
            builder.Services.AddAutoMapperConfig();
            builder.Services.AddControllersWithViews().AddRazorOptions(options =>
            {
                options.ViewLocationFormats.Add("/{0}.cshtml");
            }); //.AddRazorRuntimeCompilation();
            builder.Services.AddRazorPages();

            //
            //builder.Services.UseIISIntegration();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseIISIntegration();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                //pattern: "{controller=Home}/{action=Index}/{id?}");
                pattern: "{controller=Autuar2}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}