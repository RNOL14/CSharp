using System.Windows.Input;

namespace MauiApp7.ViewModels;

public class MainViewModel
{
  public ICommand NavigateCommand { get; }

  public MainViewModel()
  {
    NavigateCommand = new Command(async () =>
    {
      await Shell.Current.GoToAsync("DetailsPage");
    });
  }
}