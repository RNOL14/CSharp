namespace MauiAppNavigation;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnOpenSecondPage(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SecondPage());
	}
}
