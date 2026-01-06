namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    private void OnShowNameClicked(object sender, EventArgs e)
{
    string name = nameEntry.Text;
    DisplayAlert("Name", $"Hello {name}", "OK");
}
}
