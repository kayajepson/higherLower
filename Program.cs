using System;
using System.Collections.Generic;

namespace Game {

  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Would you like to pick the number? (Yes/No): ");
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
           else {
             Console.WriteLine("I've picked a number. What is your guess?");
               int x = 0;
               Random rnd = new Random();
               int randomNumber = rnd.Next(1,101);
               Console.WriteLine(randomNumber);
                 for (int i = 0; x == 0; i++)
                 {
                   string guess = Console.ReadLine();
                   int yourNumber = int.Parse(guess);

                   bool high = yourNumber < randomNumber;
                   bool low = yourNumber > randomNumber;
                   bool correct = yourNumber == randomNumber;
                   if (high)
                          {
                              Console.WriteLine("Higher");
                          }
                          else if (low)
                          {
                              Console.WriteLine("Lower");
                          }
                          else if (correct)
                          {
                              x = 1;
                              Console.WriteLine("You are correct");
                              break;
                          }
                          else Console.WriteLine("Please enter a valid choice");
                      };

                  }
           }
       }
   }
