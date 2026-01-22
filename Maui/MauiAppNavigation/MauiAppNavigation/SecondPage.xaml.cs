namespace MauiAppNavigation;

public partial class SecondPage : ContentPage
{
  public SecondPage()
  {
    InitializeComponent();
  }

  private async void OnGoBackClicked(object sender, EventArgs e)
  {
    await Navigation.PopAsync();
  }
}
