using System;

namespace Inventory.Models
{
  public class Card
  
  {
    public int InventoryId{ get; set; }
    public string Type { get; set; }
    public string Customer{ get; set; }
    public string ExpirationDate { get; set; }
  }
}