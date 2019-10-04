namespace csharp_burgershack.Models
{
  public class Drink
  {
    public string Title { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }

    // constructor
    public Drink(string title, int price, string description)
    {
      Title = title;
      Price = price;
      Description = description;
    }
  }
}