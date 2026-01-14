using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace MauiMovies;

public partial class MainPage : ContentPage
{
	string _apiKey = "c62a578c51a7f40b35c3809384a47acf";
	string _baseUrl = "https://api.themoviedb.org/3/";
	string _imageBaseUrl = "https://image.tmdb.org/t/p/w500";

	TrendingMovies _movieList;
	GenreList _genres;

	public ObservableCollection<UserGenre> Genres { get; set; } = new();
	public ObservableCollection<MovieResult> Movies { get; set; } = new();

	HttpClient _httpClient;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
		_httpClient = new HttpClient { BaseAddress = new Uri(_baseUrl) };
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		_genres = await _httpClient.GetFromJsonAsync<GenreList>(
				$"genre/movie/list?api_key={_apiKey}&language=en-US");

		_movieList = await _httpClient.GetFromJsonAsync<TrendingMovies>(
				$"trending/movie/week?api_key={_apiKey}&language=en-US");

		foreach (var movie in _movieList.results)
		{
			movie.poster_path = $"{_imageBaseUrl}{movie.poster_path}";
		}

		foreach (var genre in _genres.genres)
		{
			Genres.Add(new UserGenre
			{
				id = genre.id,
				name = genre.name,
				Selected = false
			});
		}

		LoadFilteredMovies();
	}

	void LoadFilteredMovies()
	{
		Movies.Clear();

		foreach (var movie in _movieList.results)
		{
			Movies.Add(movie);
		}
	}
}
