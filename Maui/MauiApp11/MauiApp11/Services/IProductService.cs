using MauiApp11.Models;

namespace MauiApp11.Services;

public interface IProductService
{
  Task<List<ProductDto>> SearchProducts(string searchTerm);
}
