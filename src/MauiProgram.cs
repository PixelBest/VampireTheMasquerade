using Microsoft.Extensions.Logging;
using VampireTheMasquerade.DataContext.Extensions;
using VampireTheMasquerade.Extensions;
using VampireTheMasquerade.Migrations;

namespace VampireTheMasquerade
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
					fonts.AddFont("CormorantGaramond-Regular.ttf", "CormorantGaramondRegular");
					fonts.AddFont("YesevaOne-Regular.ttf", "YesevaOneRegular");
				});
			var services = builder.Services;
			services.AddPages();
			services.AddViewModel();
			services.AddDataContext();
			services.AddMigrations();
#if DEBUG
			builder.Logging.AddDebug();
#endif
			var app = builder.Build();
			app.RunMigarions();
			return app;
		}
	}
}
