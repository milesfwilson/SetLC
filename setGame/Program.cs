using System;
using System.Collections.Generic;
using setGame.Models;

namespace setGame
{
  class Program
  {


    static void Main(string[] args)
    {

      Game game = new Game();

      List<Card> deck = game.buildDeck();
      List<Card> set = new List<Card>();

      bool running = true;
      while (running)
      {
        Console.Clear();
        set.Clear();

        game.printDeck(deck);

        Console.WriteLine(@"
                Enter Three Cards
                ");

        Console.WriteLine(game.validateSet(game.selectCards(set, deck)));

        bool exit = false;
        while (!exit)
        {

          Console.WriteLine(@"
                Continue? 
                  Y / N
                ");

          string userInput = Console.ReadLine();
          if (userInput.ToUpper() == "N")
          {
            Console.WriteLine("Exiting...");
            exit = true;
            running = false;
          }
          else if (userInput.ToUpper() == "Y")
          {
            Console.Clear();
            exit = true;
          }
          else
          {
            Console.Clear();
            Console.WriteLine("Enter a valid key");
          }
        }
      }
    }
  }
}
