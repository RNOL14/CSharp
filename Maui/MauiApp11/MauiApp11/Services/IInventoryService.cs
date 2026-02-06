using MauiApp11.Models;

namespace MauiApp11.Services;

public interface IInventoryService
{
  Task<bool> AddStockCount(ProductDto product, int count);
}
