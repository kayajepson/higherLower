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
        int x = 0;
        int number = 50;
        int highNum = 100;
        int lowNum = 0;
          for (int i = 0; x == 0; i++)
          {
            Console.WriteLine("Is your number higher or lower than " + number + "? [higher/lower/correct]");
            string answer = Console.ReadLine();

            bool high = answer == "higher";
            bool low = answer == "lower";
            bool correct = answer == "correct";
            if (high)
                   {
                       if(lowNum <= number)
                       {
                           lowNum = number;
                       };
                       number = number + (highNum - lowNum)/2;
                   }
                   else if (low)
                   {
                       if(highNum >= number)
                       {
                           highNum = number;
                       };
                       number = number - (highNum - lowNum) / 2;
                   }
                   else if (correct)
                   {
                       x = 1;
                       break;
                   }
                   else Console.WriteLine("Please enter a valid choice");
               };

           }
       }
   }
 }
