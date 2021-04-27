using System;
using System.Collections.Generic;
using setGame.Models;

namespace setGame
{
  public class Game
  {

    public List<Card> buildDeck()
    {

      List<Card> deck = new List<Card>();
      string[] shapes = { "diamond", "wave", "pill" };
      string[] shades = { "solid", "outline", "lined" };
      string[] colors = { "Red", "Green", "Blue" };
      int[] numbers = { 1, 2, 3 };

      Random random = new Random();

      for (int i = 0; i < 12; i++)
      {
        string shape = shapes[random.Next(3)];
        string shade = shades[random.Next(3)];
        string color = colors[random.Next(3)];
        int number = numbers[random.Next(3)];

        Card card = new Card(shape, shade, color, number);
        deck.Add(card);
      }
      return deck;
    }

    public void printDeck(List<Card> deck)
    {
      for (int i = 0; i < deck.Count; i++)
      {
        Console.WriteLine($"{i + 1} - {deck[i].Shape} {deck[i].Shade} {deck[i].Color} {deck[i].Number}");
      }
    }

    public List<Card> selectCards(List<Card> set, List<Card> deck)
    {
      string cardOne = Console.ReadLine();
      set.Add(deck[Int16.Parse(cardOne) - 1]);

      string cardTwo = Console.ReadLine();
      set.Add(deck[Int16.Parse(cardTwo) - 1]);

      string cardThree = Console.ReadLine();
      set.Add(deck[Int16.Parse(cardThree) - 1]);

      for (int i = 0; i < set.Count; i++)
      {
        Console.WriteLine($"{set[i].Shape} {set[i].Shade} {set[i].Color} {set[i].Number}");
      }

      return set;
    }

    public string validateSet(List<Card> set)
    {
      Card cardOne = set[0];
      Card cardTwo = set[1];
      Card cardThree = set[2];

      if (
      (cardOne.Number == cardTwo.Number && cardTwo.Number == cardThree.Number)
      ||
      (cardOne.Number != cardTwo.Number && cardTwo.Number != cardThree.Number && cardOne.Number != cardThree.Number)

      &&
      (cardOne.Shade == cardTwo.Shade && cardTwo.Shade == cardThree.Shade)
      ||
      (cardOne.Shade != cardTwo.Shade && cardTwo.Shade != cardThree.Shade && cardOne.Shade != cardThree.Shade)

      &&
      (cardOne.Shape == cardTwo.Shape && cardTwo.Shape == cardThree.Shape)
      ||
      (cardOne.Shape != cardTwo.Shape && cardTwo.Shape != cardThree.Shape && cardOne.Shape != cardThree.Shape)

      &&
      (cardOne.Color == cardTwo.Color && cardTwo.Color == cardThree.Color)
      ||
      (cardOne.Color != cardTwo.Color && cardTwo.Color != cardThree.Color && cardOne.Color != cardThree.Color))
      {
        return "Valid Set!";
      }
      else
      {
        return "Invalid Set!";
      }
    }
  }
}