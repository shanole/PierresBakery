using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadOrders { get; set;}
    public Bread(int orders)
    {
      BreadOrders = orders;
    }
    public int CalculatePrice()
    {
      int price = 5 * BreadOrders;
      int freeBread = (BreadOrders - BreadOrders%3)/3;
      int discount = 5 * freeBread;
      return price-discount;
    }
  }
}