using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp10.Models;

public class TodoItem : INotifyPropertyChanged
{
  string title;
  bool isCompleted;

  public string Title
  {
    get => title;
    set
    {
      title = value;
      OnPropertyChanged();
    }
  }

  public bool IsCompleted
  {
    get => isCompleted;
    set
    {
      isCompleted = value;
      OnPropertyChanged();
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  void OnPropertyChanged([CallerMemberName] string name = null)
      => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
