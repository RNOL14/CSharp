using System.Collections.ObjectModel;
using System.Net.Http.Json;
using MauiApp1.Models;
namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private string contentUri =
				 "https://thesimpsonsquoteapi.glitch.me/quotes?count=20";

	public ObservableCollection<Simpson> Simpsons = new();

	public MainPage()
	{
		InitializeComponent();
		MessageCollection.ItemsSource = Simpsons;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		LoadingIndicator.IsVisible = true;

		var httpClient = new HttpClient();
		var jsonResponse =
				await httpClient.GetFromJsonAsync<List<Simpson>>(contentUri);

		if (jsonResponse != null)
		{
			foreach (var s in jsonResponse)
			{
				Simpsons.Add(s);
			}
		}

		LoadingIndicator.IsVisible = false;
	}
}
