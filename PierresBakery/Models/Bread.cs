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
      return price;
    }
  }
}