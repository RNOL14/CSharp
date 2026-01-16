using System.Collections.ObjectModel;
using MauiMovies.Models;

namespace MauiMovies;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Genre> Genres { get; set; } = new();
	public ObservableCollection<Movie> Movies { get; set; } = new();

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
		LoadStaticData();
	}

	private void LoadStaticData()
	{
		// Static genres
		Genres.Add(new Genre { Id = 1, Name = "Action" });
		Genres.Add(new Genre { Id = 2, Name = "Comedy" });
		Genres.Add(new Genre { Id = 3, Name = "Drama" });

		// Static movies
		Movies.Add(new Movie
		{
			Title = "Spider Hero",
			Poster = "poster1.jpg",
			Rating = 7.5,
			GenreIds = new List<int> { 1 }
		});

		Movies.Add(new Movie
		{
			Title = "Funny Days",
			Poster = "poster2.jpg",
			Rating = 6.8,
			GenreIds = new List<int> { 2 }
		});

		Movies.Add(new Movie
		{
			Title = "Life Story",
			Poster = "poster3.jpg",
			Rating = 8.2,
			GenreIds = new List<int> { 3 }
		});

		Movies.Add(new Movie
		{
			Title = "Action Comedy",
			Poster = "poster4.jpg",
			Rating = 7.9,
			GenreIds = new List<int> { 1, 2 }
		});
	}
}