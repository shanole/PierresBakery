namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryOrders {get; set;}
    public Pastry(int orders)
    {
      PastryOrders = orders;
    }
    public int CalculatePrice()
    {
      int singlePastries = PastryOrders%3;
      int groupsOfThree = (PastryOrders - singlePastries)/3;

      return singlePastries*2 + groupsOfThree*5;
    }
  }
}