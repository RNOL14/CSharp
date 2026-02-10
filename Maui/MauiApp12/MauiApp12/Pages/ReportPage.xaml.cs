using MauiApp12.ViewModels;

namespace MauiApp12.Pages;

public partial class ReportPage : ContentPage
{
  private readonly ReportViewModel _viewModel;

  public ReportPage(ReportViewModel viewModel)
  {
    InitializeComponent();

    _viewModel = viewModel;
    BindingContext = _viewModel;
  }

  protected override async void OnAppearing()
  {
    base.OnAppearing();
    await _viewModel.Init();
  }
}
