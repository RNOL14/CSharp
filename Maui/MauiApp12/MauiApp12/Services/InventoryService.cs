using MauiApp12.Models;

namespace MauiApp12.Services
{
  public class InventoryService
  {
    private readonly List<ProductDto> _products =
[
    new ProductDto { ProductId = 1, ProductName = "Mad Longboard", ProductCategory = "Mad Lab Boards", ManufacturerName="Mad Lab Boards" },
    new ProductDto { ProductId = 2, ProductName = "Mad Shortboard", ProductCategory = "Mad Lab Boards", ManufacturerName="Mad Lab Boards" },
    new ProductDto { ProductId = 3, ProductName = "Mad Custom", ProductCategory = "Mad Lab Boards", ManufacturerName="Mad Lab Boards" },
    new ProductDto { ProductId = 4, ProductName = "Mad Longboard Pro", ProductCategory = "Mad Lab Boards", ManufacturerName="Mad Lab Boards" },
];
    private readonly List<InventoryItemDto> _inventory = [];

    public Task<List<ProductDto>> SearchProducts(string searchText)
    {
      if (string.IsNullOrWhiteSpace(searchText))
        return Task.FromResult(new List<ProductDto>());

      var result = _products
          .Where(p => p.ProductName.ToLower().Contains(searchText.ToLower()))
          .ToList();

      return Task.FromResult(result);
    }

    public Task AddCount(int productId, int count)
    {
      var product = _products.First(p => p.ProductId == productId);

      var existing = _inventory.FirstOrDefault(x => x.ProductId == productId);

      if (existing == null)
      {
        _inventory.Add(new InventoryItemDto
        {
          ProductId = product.ProductId,
          ProductName = product.ProductName,
          ManufacturerName = product.ManufacturerName,
          Count = count,
          CountedByName = "admin@localhost",
          CountedAt = DateTime.Now
        });
      }
      else
      {
        existing.Count += count;
      }

      return Task.CompletedTask;
    }

    public Task<List<InventoryItemDto>> GetInventory()
    {
      return Task.FromResult(_inventory.ToList());
    }
  }
}
