using MauiApp8.Services;
namespace MauiApp8;

public partial class MainPage : ContentPage
{


	private readonly ICounterService _counterService;

	public MainPage(ICounterService counterService)
	{
		InitializeComponent();
		_counterService = counterService;
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		int count = _counterService.Increment();

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
