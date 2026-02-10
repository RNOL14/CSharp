using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiApp12.Models;
using MauiApp12.Pages;

namespace MauiApp12.ViewModels;

public class ReportViewModel : BaseViewModel
{
  public ObservableCollection<InventoryItemDto> Inventory { get; set; } = new();

  public ICommand ShowAboutPageCommand { get; }

  private bool _initialized;

  public ReportViewModel()
  {
    IsLoading = true;
    ShowAboutPageCommand = new Command(ShowAboutPage);
  }

  public async Task Init()
  {
    if (_initialized)
      return;

    _initialized = true;
    await Refresh();
  }

  private async Task Refresh()
  {
    IsLoading = true;

    await Task.Delay(800); // fake delay

    Inventory.Clear();

    Inventory.Add(new InventoryItemDto
    {
      ProductName = "SoyBoy Board Wax",
      ManufacturerName = "Bobbie's Surf Supplies",
      Count = 2,
      CountedByName = "administrator@localhost",
      CountedAt = DateTime.Now.AddDays(-2)
    });

    Inventory.Add(new InventoryItemDto
    {
      ProductName = "Leggy Leash",
      ManufacturerName = "Bobbie's Surf Supplies",
      Count = 2,
      CountedByName = "administrator@localhost",
      CountedAt = DateTime.Now.AddDays(-1)
    });

    Inventory.Add(new InventoryItemDto
    {
      ProductName = "Fin pack",
      ManufacturerName = "Bobbie's Surf Supplies",
      Count = 0,
      CountedByName = "",
      CountedAt = DateTime.MinValue
    });

    Inventory.Add(new InventoryItemDto
    {
      ProductName = "Mad Longboard",
      ManufacturerName = "Mad Lad Boards",
      Count = 1,
      CountedByName = "administrator@localhost",
      CountedAt = DateTime.Now
    });

    Inventory.Add(new InventoryItemDto
    {
      ProductName = "Mad Shortboard",
      ManufacturerName = "Mad Lad Boards",
      Count = 4,
      CountedByName = "administrator@localhost",
      CountedAt = DateTime.Now.AddHours(-5)
    });

    Inventory.Add(new InventoryItemDto
    {
      ProductName = "Mad Custom",
      ManufacturerName = "Mad Lad Boards",
      Count = 0,
      CountedByName = "",
      CountedAt = DateTime.MinValue
    });

    IsLoading = false;
  }

  private void ShowAboutPage()
  {
    // MULTI-WINDOW (like book)
    var newWindow = new Window(new AboutPage())
    {
      Title = "About",
      Width = 400,
      Height = 300
    };

    Application.Current?.OpenWindow(newWindow);
  }
}
