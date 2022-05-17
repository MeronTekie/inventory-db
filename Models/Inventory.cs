using System;

namespace Inventory.Models
{
  public class Inventory
  
  {
    public int CardId{ get; set; }
    public string Type { get; set; }
    public string Customer{ get; set; }
    public string ExpirationDate { get; set; }
  }
}