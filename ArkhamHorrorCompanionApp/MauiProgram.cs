using Microsoft.Extensions.Logging;

namespace ArkhamHorrorCompanionApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("UnutterableItalic-jE2E9", "OpenSansRegular");
				fonts.AddFont("Unutterable-z8E8X", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
