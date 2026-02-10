using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp12.ViewModels
{
  public class BaseViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler? PropertyChanged;

    private bool _isLoading;
    public bool IsLoading
    {
      get => _isLoading;
      set
      {
        _isLoading = value;
        OnPropertyChanged();
      }
    }

    protected bool initialized = false;

    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
  }
}
