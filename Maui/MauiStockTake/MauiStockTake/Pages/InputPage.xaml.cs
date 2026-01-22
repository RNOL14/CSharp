namespace MauiStockTake.Pages;

public partial class InputPage : ContentPage
{
  public InputPage()
  {
    InitializeComponent();
  }

  private async void Button_Clicked(object sender, EventArgs e)
  {
    await Shell.Current.DisplayAlert("OK", "Input Page Loaded", "Close");
  }
}