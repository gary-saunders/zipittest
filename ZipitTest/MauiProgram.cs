using MauiApp1;
using Microsoft.Extensions.Logging;

namespace ZipitTest;

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
			Routing.RegisterRoute(nameof(SecondPage), typeof(SecondPage));

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
