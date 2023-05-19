
//using Infra.Context;
using Infra.Context;
using Infra.EntityConfig;
using IOC;
using Microsoft.AspNetCore.Identity;
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

            // Add services to the container.
            //var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionHSS") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            

            // services.AddDbContext<ContextoAplicacao>(options =>
          

           /*---builder.Services.AddDbContext<ContextoAplicacao>(options => options.UseSqlServer(connectionString)
                                                                                    //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                                                                                    );*/

            //builder.Services.AddDbContext<ContextoAplicacao>();

            //builder.Services.AddDbContextFactory<ContextoAplicacao>(options => options.UseSqlServer(connectionString));
            /* builder.Services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(connectionString));
             builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            */
            ///builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false);
            //builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false);//.AddEntityFrameworkStores<ContextoAplicacao>();

            // Minhas Adi��es

            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ContextoAplicacao>();

            // builder.Services.Configure<SendinBlueSettings>(builder.Configuration.GetSection("SendinBlueSettings"));
            //builder.Services.AddSingleton<IEmailService, SendinBlueService>();
            //builder.Services.AddSingleton<IWhatsappService, TwilioWhatsappService>();
            builder.Services.AddAutoMapperConfig();
            /// builder.Services.AddDbContext<CameraDatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
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
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}