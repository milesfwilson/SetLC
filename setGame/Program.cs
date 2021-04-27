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
        // empty set 
        Console.WriteLine("Enter Three Cards");

        game.printDeck(deck);

        Console.WriteLine(game.validateSet(game.selectCards(set, deck)));

        Console.WriteLine(@"
        Continue? 
        Y / N
        ");

        string userInput = Console.ReadLine();
        if (userInput.ToUpper() == "N")
        {
          Console.WriteLine("Exiting...");
          running = false;
        }
        else if (userInput.ToUpper() == "Y")
        {
          Console.Clear();
        }
        else
        {
          Console.WriteLine("Enter a valid key");
        }
      }
    }
  }
}
