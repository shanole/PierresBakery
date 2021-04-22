using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
   [TestMethod]
   public void BreadConstructor_CreatesNewInstanceOfBread_Bread()
   {
     Bread testBread = new Bread(1);
     Assert.AreEqual(typeof(Bread),testBread.GetType());
   } 
   [TestMethod]
   public void GetBreadOrders_ReturnsNumberofOrders_Int()
   {
     int orders = 2;
     Bread testBread = new Bread(orders);
     int result = Bread.BreadOrders;
     Assert.AreEqual(orders,result);
   }
   [TestMethod]
   public void CalculatePrice_ReturnsPriceOfOneBread_5()
   {
     int order = 1;
     Bread testBread = new Bread(order);
     int price = testBread.CalculatePrice();
     Assert.AreEqual(5,price);
   }
   [TestMethod]
   public void CalculatePrice_ReturnsPriceOfTwoBreads_10()
   {
     int order = 2;
      Bread testBread = new Bread(order);
     int price = testBread.CalculatePrice();
     Assert.AreEqual(10,price);
   }
  }
}