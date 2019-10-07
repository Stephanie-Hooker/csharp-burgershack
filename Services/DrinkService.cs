using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.Services
{
  public class DrinkService
  {
    public List<Drink> Drinks { get; private set; }
    public List<string> Messages { get; set; }
    public DrinkService() //constructor
    {
      Drinks = new List<Drink>();
      Messages = new List<string>();
      Setup();
    }


    public void Setup()
    {
      Drink coffee = new Drink("Carmel Mocha", 5, "Hot and Yummy");
      Drink tea = new Drink("Milk Tea", 4, "yummy");
      Drink water = new Drink("water", 2, "it's good for you");
      Drink lacroix = new Drink("LaCroix", 3, "lightly flavored water");

      Drinks.AddRange(new Drink[] { coffee, tea, water, lacroix });
    }

    public void GetDrinks(int index)
    {
      if (index < Drinks.Count && index > -1)
      {
        Drink d = Drinks[index];
        Messages.Add($@"
        Title: {d.Title}
        Price: {d.Price}
        Description: {d.Description}
        press any key to return to the main menu
        ");
      }
      else
      {
        Messages.Add("Invalid Choice");
      }
    }
    public void GetDrinks()
    {
      Messages.Add("Available Drinks");
      for (int i = 0; i < Drinks.Count; i++)
      {
        Drink d = Drinks[i];
        Messages.Add($"{i + 1}: {d.Title} - {d.Price} - {d.Description}");
      }
    }

  }
}