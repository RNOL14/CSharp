using Microsoft.Extensions.DependencyInjection;

namespace MauiStocktak;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}

	// We will use this later for theme switching
	public static Helpers.Theme Theme { get; set; } = Helpers.Theme.Default;

	// protected override Window CreateWindow(IActivationState? activationState)
	// {
	// 	return new Window(new AppShell());
	// }
}