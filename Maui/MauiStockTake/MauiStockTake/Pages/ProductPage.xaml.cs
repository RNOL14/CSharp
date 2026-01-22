using MauiStockTake.Models;
using System.ComponentModel;

namespace MauiStockTake.Pages;

[QueryProperty(nameof(Product), "Product")]
public partial class ProductPage : ContentPage, INotifyPropertyChanged
{
  Product product;

  public Product Product
  {
    get => product;
    set
    {
      product = value;
      ProductName = product.Name;
      ManufacturerName = product.ManufacturerName;
    }
  }

  string productName;
  public string ProductName
  {
    get => productName;
    set
    {
      productName = value;
      OnPropertyChanged();
    }
  }

  string manufacturerName;
  public string ManufacturerName
  {
    get => manufacturerName;
    set
    {
      manufacturerName = value;
      OnPropertyChanged();
    }
  }

  public ProductPage()
  {
    InitializeComponent();
    BindingContext = this;
  }
}
