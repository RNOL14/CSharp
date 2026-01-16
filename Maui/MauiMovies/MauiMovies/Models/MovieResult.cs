namespace MauiMovies.Models;

public class MovieResult
{
  public string original_language { get; set; } = string.Empty;
  public string poster_path { get; set; } = string.Empty;
  public string overview { get; set; } = string.Empty;
  public string release_date { get; set; } = string.Empty;
  public string backdrop_path { get; set; } = string.Empty;
  public string title { get; set; } = string.Empty;
  public string media_type { get; set; } = string.Empty;

  public double vote_average { get; set; }
  public int vote_count { get; set; }
  public int id { get; set; }

  public List<int> genre_ids { get; set; } = new();
}