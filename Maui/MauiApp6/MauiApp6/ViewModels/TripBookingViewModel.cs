using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp6.ViewModels;

public class TripBookingViewModel : INotifyPropertyChanged
{
  string destination;
  string travelType;
  string transport;
  bool insurance;
  DateTime travelDate = DateTime.Today;

  public string Destination
  {
    get => destination;
    set { destination = value; OnPropertyChanged(); }
  }

  public string TravelType
  {
    get => travelType;
    set { travelType = value; OnPropertyChanged(); }
  }

  public string Transport
  {
    get => transport;
    set { transport = value; OnPropertyChanged(); }
  }

  public bool Insurance
  {
    get => insurance;
    set { insurance = value; OnPropertyChanged(); }
  }

  public DateTime TravelDate
  {
    get => travelDate;
    set { travelDate = value; OnPropertyChanged(); }
  }

  public ICommand BookCommand => new Command(OnBook);

  void OnBook()
  {
    if (string.IsNullOrWhiteSpace(Destination) ||
        string.IsNullOrWhiteSpace(TravelType) ||
        string.IsNullOrWhiteSpace(Transport))
    {
      Application.Current.MainPage.DisplayAlert(
          "Validation",
          "Please fill all required fields",
          "OK");
      return;
    }

    Application.Current.MainPage.DisplayAlert(
        "Success",
        "Trip booked successfully",
        "OK");
  }

  public event PropertyChangedEventHandler PropertyChanged;
  void OnPropertyChanged([CallerMemberName] string name = null)
      => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
