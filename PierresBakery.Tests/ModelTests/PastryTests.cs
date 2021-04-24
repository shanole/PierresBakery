using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
   public void PastryConstructor_CreatesNewInstanceOfPastry_Pastry()
   {
     Pastry testPastry = new Pastry(1);
     Assert.AreEqual(typeof(Pastry),testPastry.GetType());
   }
   public void GetPastryOrders_ReturnsNumberofOrders_Int()
   {
     int orders = 2;
     Pastry testPastry = new Pastry(orders);
     int result = testPastry.PastryOrders;
     Assert.AreEqual(orders,result);
   }
  }
}