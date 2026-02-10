using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiApp12.Models;
using MauiApp12.Services;

namespace MauiApp12.ViewModels
{
  public class InputViewModel : BaseViewModel
  {
    private readonly InventoryService _inventoryService;

    public ObservableCollection<ProductDto> Products { get; set; } = new();

    private string _searchText = "";
    public string SearchText
    {
      get => _searchText;
      set
      {
        _searchText = value;
        OnPropertyChanged();
      }
    }

    private ProductDto? _selectedProduct;
    public ProductDto? SelectedProduct
    {
      get => _selectedProduct;
      set
      {
        _selectedProduct = value;
        OnPropertyChanged();
      }
    }

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

    public ICommand SearchCommand { get; }
    public ICommand AddCountCommand { get; }

    public InputViewModel(InventoryService inventoryService)
    {
      _inventoryService = inventoryService;

      SearchCommand = new Command(async () => await Search());
      AddCountCommand = new Command(async () => await AddCount());
    }

    private async Task Search()
    {
      IsLoading = true;

      Products.Clear();
      SelectedProduct = null;
      Count = 0;

      var results = await _inventoryService.SearchProducts(SearchText);

      foreach (var product in results)
        Products.Add(product);

      IsLoading = false;
    }

    private async Task AddCount()
    {
      if (SelectedProduct == null)
        return;

      await _inventoryService.AddCount(SelectedProduct.ProductId, Count);

      Count = 0;
    }
  }
}
