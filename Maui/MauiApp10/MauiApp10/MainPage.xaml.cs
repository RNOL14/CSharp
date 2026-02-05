using MauiApp10.Models;
namespace MauiApp10;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MauiTodoViewModel();
	}

}
