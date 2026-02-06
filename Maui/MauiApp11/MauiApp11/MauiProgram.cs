using Microsoft.Extensions.Logging;
using MauiApp11.UI.Pages;
using MauiApp11.UI.ViewModels;
using MauiApp11.Services;

namespace MauiApp11;

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

		builder.Services.AddTransient<InputViewModel>();
		builder.Services.AddTransient<InputPage>();

		builder.Services.AddSingleton<IProductService, ProductService>();
		builder.Services.AddSingleton<IInventoryService, InventoryService>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
