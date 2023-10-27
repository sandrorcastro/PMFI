using Fiscalizacao.Context;
using Fiscalizacao.Data;
using Fiscalizacao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Fiscalizacao
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            


            builder.Services.AddSingleton<ImovelService>();

            //builder.Services.AddTransient<Imo>();
            builder.Services.AddSingleton<ImovelDatabase>();

            builder.Services.AddDbContext<ImoveisDBContext>(options => {
                //options.UseSqlServer(configuration.GetConnectionString("DefaultConnection-SRC-PMFI"),
                // options.UseSqlite("Data Source = NaRua.db3");
                options.UseSqlite("Data Source = C:\\GIT\\PMFI\\BoasPraticas\\Fiscalizacao\\Fiscalizacao\\NaRua.db3");




            //C:\GIT\PMFI\BoasPraticas\Fiscalizacao\Fiscalizacao

                //Data Source = LocalDatabase.db
                //b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif


            return builder.Build();
        }
    }
}