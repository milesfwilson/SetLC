namespace setGame.Models
{
  public class Card
  {
    public Card(string shape, string color, string shade, int number)
    {
      Shape = shape;
      Color = color;
      Shade = shade;
      Number = number;
    }

    public string Shape { get; set; }
    public string Color { get; set; }

    public string Shade { get; set; }

    public int Number { get; set; }
  }
}