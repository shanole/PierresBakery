namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryOrders {get; set;}
    public Pastry(int orders)
    {
      PastryOrders = orders;
    }
  }
}