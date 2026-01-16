namespace MauiMovies.Models;

public class Movie
{
  public string Title { get; set; } = string.Empty;
  public string Poster { get; set; } = string.Empty;
  public double Rating { get; set; }
  public List<int> GenreIds { get; set; } = new();
}