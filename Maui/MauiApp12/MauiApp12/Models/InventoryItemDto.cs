namespace MauiApp12.Models;

public class InventoryItemDto
{
  public int ProductId { get; set; }
  public string ProductName { get; set; } = "";
  public string ManufacturerName { get; set; } = "";

  public int Count { get; set; }

  public string CountedByName { get; set; } = "";
  public DateTime CountedAt { get; set; }
}
