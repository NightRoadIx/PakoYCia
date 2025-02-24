using Microsoft.Extensions.Logging;

namespace PakoYCia
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
// Para la creación de un programa
// Modo de prueba DEBUG
// Modo de producción
#if DEBUG
            // Log o archivo de captura de errores / excepciones
    		builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
