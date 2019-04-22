using System;
using System.Collections.Generic;

namespace Game {

  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Would you like to play the higher/lower game? (Yes/No): ");
      string startGame = Console.ReadLine();
      if (startGame == "Yes" || startGame == "yes" || startGame == "y" || startGame == "Y")
      {
        
      }
      else
      {
        Console.WriteLine("GoodBye");
      }
      //
      // int maxPrice = int.Parse(stringMaxPrice);
      //
      // Console.WriteLine("Enter maximum miles: ");
      // string stringMaxMiles = Console.ReadLine();
      // int maxMiles = int.Parse(stringMaxMiles);
      //
      // List<Car> CarsMatchingSearch = new List<Car>(0);
      //
      // foreach (Car automobile in Cars)
      // {
      //   if (automobile.WorthBuying(maxPrice) && automobile.WorthMiles(maxMiles))
      //   {
      //     CarsMatchingSearch.Add(automobile);
      //   } else if (!automobile.WorthBuying(maxPrice) && !automobile.WorthMiles(maxMiles)) {
      //     Console.WriteLine("Lower your standards");
      //     break;
      //   }
      // }
      //
      // foreach(Car automobile in CarsMatchingSearch)
      // {
      //   Console.WriteLine("----------------------");
      //   Console.WriteLine(automobile.GetMakeModel());
      //   Console.WriteLine(automobile.GetMiles() + " miles");
      //   Console.WriteLine("$" + automobile.GetPrice());
      //   Console.WriteLine(automobile.GetColor());
      // }
    }
  }

}
