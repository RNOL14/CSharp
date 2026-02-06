using MauiApp11.Models;

namespace MauiApp11.Services;

public class ProductService : IProductService
{
  private readonly List<ProductDto> _products = new()
    {
        new ProductDto { Id = 1, Name = "Mad Longboard", ManufacturerName = "Mad Lab Boards" },
        new ProductDto { Id = 2, Name = "Mad Shortboard", ManufacturerName = "Mad Lab Boards" },
        new ProductDto { Id = 3, Name = "Mad Custom", ManufacturerName = "Mad Lab Boards" }
    };

  public Task<List<ProductDto>> SearchProducts(string searchTerm)
  {
    var results = _products
        .Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
        .ToList();

    return Task.FromResult(results);
  }
}
