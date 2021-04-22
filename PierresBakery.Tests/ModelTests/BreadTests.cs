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
     Assert.AreEqual(orders,Bread.BreadOrders);
   }
  }
}