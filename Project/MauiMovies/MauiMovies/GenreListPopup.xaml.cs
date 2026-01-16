using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using MauiMovies.Models;

namespace MauiMovies;

public partial class GenreListPopup : Popup
{
  public ObservableCollection<Genre> Genres { get; set; }

  public GenreListPopup(ObservableCollection<Genre> genres)
  {
    InitializeComponent();
    Genres = genres;
    BindingContext = this;
  }

  private void Confirm_Clicked(object sender, EventArgs e)
  {
    Close(true);
  }
}
