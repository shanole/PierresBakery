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
   [TestMethod]
   public void GetPastryOrders_ReturnsNumberofOrders_Int()
   {
     int orders = 2;
     Pastry testPastry = new Pastry(orders);
     int result = testPastry.PastryOrders;
     Assert.AreEqual(orders,result);
   }
   [TestMethod]
   public void CalculatePrice_ReturnsPriceOfOnePastry_2()
   {
     int order = 1;
     Pastry testPastry = new Pastry(order);
     int price = testPastry.CalculatePrice();
     Assert.AreEqual(2,price);
   }
   [TestMethod]
   public void CalculatePrice_ReturnsPriceOfTwoPastries_4()
   {
     int order = 2;
     Pastry testPastry = new Pastry(order);
     int price = testPastry.CalculatePrice();
     Assert.AreEqual(4,price);
   }
  }
}