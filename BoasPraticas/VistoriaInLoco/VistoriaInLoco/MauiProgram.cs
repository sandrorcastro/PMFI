using Microsoft.Extensions.Logging;
using VistoriaInLoco.Context;
using VistoriaInLoco.Views;
namespace VistoriaInLoco
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
                });
            builder.Services.AddDbContext<VistoriaDBContext>();
            builder.Services.AddDbContext<ImovelCheckDBContext>();
            builder.Services.AddSingleton<VistoriaListPage>();
            builder.Services.AddTransient<VistoriaPage>();
            builder.Services.AddTransient<MainPage>();
            //builder.Services.AddTransient<VistoriaListPage>();

            var vistoriaDBContext = new VistoriaDBContext();
            vistoriaDBContext.Database.EnsureCreated();
            vistoriaDBContext.Dispose();
            var imovelCheckDBContext = new VistoriaDBContext();
            imovelCheckDBContext.Database.EnsureCreated();
            imovelCheckDBContext.Dispose();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}