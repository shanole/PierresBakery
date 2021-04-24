using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We serve bread and pastries. \nA single loaf of bread costs $5, and we are currently having a buy 2 get 1 free deal. \nPastries are $2 each or 3 for $5.");
      Console.WriteLine();
      Console.WriteLine("How many loaves of bread would you like to order today? Please enter below:");
      Bread breadOrders = new Bread(int.Parse(Console.ReadLine()));
      Console.WriteLine("And how many pastries would you like today? Please enter below:");
      Pastry pastryOrders = new Pastry(int.Parse(Console.ReadLine()));
      int total = breadOrders.CalculatePrice() + pastryOrders.CalculatePrice();
      Console.WriteLine("Thank you. your total today is $" + total);
    }
  }
}