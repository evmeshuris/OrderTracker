using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Price { get; set; }
    public int Id { get; }
    public int VendorId { get; set; } 
    private static List<Order> _instances = new List<Order> {};

    public Order (int vendorId, string description, int price)
    {
      Description = description;
      Price = price;
      Id = _instances.Count;
        VendorId = vendorId;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
