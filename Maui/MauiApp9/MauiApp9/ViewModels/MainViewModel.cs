using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp9.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
  private int _count;

  public ObservableCollection<string> Clicks { get; } = new();

  public string CountText =>
      _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";

  public ICommand IncrementCommand { get; }

  public MainViewModel()
  {
    IncrementCommand = new Command(() =>
    {
      _count++;
      Clicks.Add($"Clicked {_count}");
      OnPropertyChanged(nameof(CountText));
    });
  }

  public event PropertyChangedEventHandler? PropertyChanged;

  protected void OnPropertyChanged([CallerMemberName] string name = "")
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
  }
}

// using System.ComponentModel;
// using System.Runtime.CompilerServices;
// using System.Windows.Input;

// namespace MauiApp9.ViewModels;

// public class MainViewModel : INotifyPropertyChanged
// {
//   private int _count;

//   public string CountText =>
//       _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";

//   public ICommand IncrementCommand { get; }

//   public MainViewModel()
//   {
//     IncrementCommand = new Command(() =>
//     {
//       _count++;
//       OnPropertyChanged(nameof(CountText));
//     });
//   }

//   public event PropertyChangedEventHandler? PropertyChanged;

//   protected void OnPropertyChanged([CallerMemberName] string name = "")
//   {
//     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//   }
// }

// using System.ComponentModel;
// using System.Runtime.CompilerServices;

// namespace MauiApp9.ViewModels;

// public class MainViewModel : INotifyPropertyChanged
// {
//   private int _count;

//   public string CountText =>
//       _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";

//   public void Increment()
//   {
//     _count++;
//     OnPropertyChanged(nameof(CountText));
//   }

//   public event PropertyChangedEventHandler? PropertyChanged;

//   protected void OnPropertyChanged([CallerMemberName] string name = "")
//   {
//     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//   }
// }
