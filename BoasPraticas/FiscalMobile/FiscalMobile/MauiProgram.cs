using FiscalMobile.Context;
using FiscalMobile.Views;
using Microsoft.Extensions.Logging;

namespace FiscalMobile
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }) ;
            builder.Services.AddTransient<MainPage>();
            // builder.Services.AddDbContext<VistoriaDBContext>();
            //builder.Services.AddDbContext<ImovelCheckDBContext>();
            builder.Services.AddDbContext<FiscalMobileDBContext>();
            //builder.Services.AddSingleton<VistoriaListPage>();
            builder.Services.AddTransient<VistoriaListPage>();
            builder.Services.AddTransient<VistoriaPage>();
          //  var vistoriaDBContext = new VistoriaDBContext();
            //vistoriaDBContext.Database.EnsureCreated();
            //vistoriaDBContext.Dispose();
         //   var imovelCheckDBContext = new ImovelCheckDBContext();
          //  imovelCheckDBContext.Database.EnsureCreated();
          //  imovelCheckDBContext.Dispose();
          
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}