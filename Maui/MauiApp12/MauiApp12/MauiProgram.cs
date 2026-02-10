using Microsoft.Extensions.Logging;
using MauiApp12.Pages;
using MauiApp12.Services;
using MauiApp12.ViewModels;

namespace MauiApp12;

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
		builder.Services.AddSingleton<InventoryService>();

		builder.Services.AddTransient<InputViewModel>();
		builder.Services.AddTransient<ReportViewModel>();

		builder.Services.AddTransient<InputPage>();
		builder.Services.AddTransient<ReportPage>();
		builder.Services.AddTransient<ReportViewModel>();
		builder.Services.AddTransient<ReportPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
