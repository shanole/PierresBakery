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
      return 5;
    }
  }
}