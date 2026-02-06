using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiApp11.Models;
using MauiApp11.Services;

namespace MauiApp11.UI.ViewModels;

public class InputViewModel : BaseViewModel
{
  private readonly IProductService _productService;
  private readonly IInventoryService _inventoryService;

  public ICommand SearchProductsCommand { get; set; }
  public ICommand AddCountCommand { get; set; }

  public ObservableCollection<ProductDto> SearchResults { get; set; } = new();

  public ProductDto SelectedProduct { get; set; }

  private int _count;
  public int Count
  {
    get => _count;
    set
    {
      _count = value;
      OnPropertyChanged();
    }
  }

  public InputViewModel(
      IProductService productService,
      IInventoryService inventoryService)
  {
    _productService = productService;
    _inventoryService = inventoryService;

    SearchProductsCommand = new Command<string>(
        async (term) => await UpdateSearchResults(term));

    AddCountCommand = new Command(
        async () => await AddCount());
  }

  private async Task UpdateSearchResults(string searchTerm)
  {
    IsLoading = true;
    SearchResults.Clear();

    var results = await _productService.SearchProducts(searchTerm);

    IsLoading = false;

    results.ForEach(r => SearchResults.Add(r));
  }

  private async Task AddCount()
  {
    if (SelectedProduct == null)
    {
      await App.Current.MainPage.DisplayAlert(
          "Product Required",
          "You have not selected a product to record",
          "OK");
      return;
    }

    IsLoading = true;

    var added = await _inventoryService.AddStockCount(
        SelectedProduct,
        Count);

    IsLoading = false;

    if (added)
    {
      await App.Current.MainPage.DisplayAlert(
          "Added",
          "Stock count has been added to inventory",
          "OK");

      ResetForm();
    }
    else
    {
      await App.Current.MainPage.DisplayAlert(
          "Error",
          "Something went wrong, please try again.",
          "OK");
    }
  }

  private void ResetForm()
  {
    SearchResults.Clear();
    Count = 0;
    SelectedProduct = null;
  }
}
