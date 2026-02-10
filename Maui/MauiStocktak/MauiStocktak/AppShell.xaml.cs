using MauiStocktak.Pages;

namespace MauiStocktak;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// LoginPage is the start page
		Items.Add(new ShellContent
		{
			Title = "Login",
			Content = new LoginPage(),
			Route = "LoginPage"
		});

		// Register route for navigation
		Routing.RegisterRoute("InputPage", typeof(InputPage));
	}
}
