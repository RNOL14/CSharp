using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace StepperCustom;

public class InputViewModel : INotifyPropertyChanged
{
  private int _count;

  public int Count
  {
    get => _count;
    set
    {
      if (_count != value)
      {
        _count = value;
        OnPropertyChanged();
      }
    }
  }

  public ICommand ResetCommand { get; }

  public InputViewModel()
  {
    Count = 0;

    ResetCommand = new Command(() =>
    {
      Count = 0;
    });
  }

  public event PropertyChangedEventHandler? PropertyChanged;

  private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}
