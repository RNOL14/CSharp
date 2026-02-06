using MauiApp11.Models;

namespace MauiApp11.Services;

public class InventoryService : IInventoryService
{
  public Task<bool> AddStockCount(ProductDto product, int count)
  {
    // Simulate API success
    return Task.FromResult(true);
  }
}
