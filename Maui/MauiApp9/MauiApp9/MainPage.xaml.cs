using MauiApp9.ViewModels;
namespace MauiApp9;

public partial class MainPage : ContentPage
{
	// private readonly MainViewModel _vm;

	public MainPage()
	{
		InitializeComponent();
		// _vm = new MainViewModel();
		// BindingContext = _vm;
		BindingContext = new MainViewModel();
	}

	// private void OnCounterClicked(object sender, EventArgs e)
	// {
	// 	_vm.Increment();
	// }
}
