using MauiApp12.ViewModels;

namespace MauiApp12.Pages;

public partial class InputPage : ContentPage
{
  public InputPage(InputViewModel viewModel)
  {
    InitializeComponent();
    BindingContext = viewModel;
  }
}
