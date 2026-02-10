using Microsoft.Extensions.DependencyInjection;

namespace StepperCustom;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new NavigationPage(new Pages.InputPage());
	}


}