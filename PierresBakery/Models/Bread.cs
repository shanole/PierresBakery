using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int BreadOrders {get; set;}
    public Bread(int orders)
    {
      BreadOrders = orders;
    }
    public int CalculatePrice()
    {
      int price = 5 * BreadOrders;
      if (BreadOrders % 3 == 0)
      {
        price -= 5*BreadOrders/3;
      }
      else if (BreadOrders > 3)
      {
        int notBonus = BreadOrders % 3;
        Console.WriteLine(notBonus);
        price = price - 5*(BreadOrders-notBonus)/3;
      }
      return price;
    }
  }
}