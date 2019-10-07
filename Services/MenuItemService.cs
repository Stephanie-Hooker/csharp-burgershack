using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.Services
{
  public class DrinkService
  {
    public List<MenuItem> MenuItems { get; private set; }
    public List<string> Messages { get; set; }
    public DrinkService() //constructor
    {
      MenuItems = new List<MenuItem>();
      Messages = new List<string>();
      Setup();
    }


    public void Setup()
    {
      Drink coffee = new Drink("Coffee", 5, "Hot and Yummy");
      Drink tea = new Drink("Iced Tea", 4, "yummy");
      Drink water = new Drink("water", 2, "it's good for you");
      Drink soda = new Drink("soda", 3, "pick your favorite soda");

      Entree burger = new Entree("bacon burger", 8, "bacon!!!11");
      Entree cheeseBurger = new Entree("cheese burger", 7, "Cheesy");
      Entree chickenNuggets = new Entree("Chicken nuggets", 6, "brings out your inner child");

      Sides fries = new Sides("fries", 2, "best fries in town");
      Sides chips = new Sides("chips", 2, "crunchy and delicious");


      MenuItems.AddRange(new MenuItem[] { coffee, tea, water, soda, burger, cheeseBurger, chickenNuggets, fries, chips });
    }

    internal void GetDrinks(int index)
    {
      if (index < MenuItems.Count && index > -1)
      {
        MenuItem menuItem = MenuItems[index];
        Messages.Add(menuItem.GetTemplate());
      }
      else
      {
        Messages.Add("Invalid Choice");
      }
    }
    public void GetDrinks()
    {
      Messages.Add("Available Menu Items");
      for (int i = 0; i < MenuItems.Count; i++)
      {
        MenuItem d = MenuItems[i];
        Messages.Add($"{i + 1}: {d.Title} - {d.Price} - {d.Description}");
      }

    }

  }
}