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
     Pastry testPastry = new Pastry();
     Assert.AreEqual(typeof(Pastry),testPastry.GetType());
   } 
  }
}