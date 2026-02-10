namespace MauiApp12.Models;

public class ProductDto
{
  public int ProductId { get; set; }
  public string ProductName { get; set; } = "";
  public string ProductCategory { get; set; } = "";

  // NEW (needed for ReportPage desktop view)
  public string ManufacturerName { get; set; } = "";
}
