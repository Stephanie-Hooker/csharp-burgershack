using System;
using csharp_burgershack.Services;

namespace csharp_burgershack.Controllers
{
  public class DrinkController
  {
    private DrinkService _drinkService { get; set; } = new DrinkService();

    public void UserInput()
    {
      Console.WriteLine("press Q to quit");
      string choice = Console.ReadLine().ToLower();
      switch (choice)
      {
        case "q":
          Environment.Exit(1);
          break;
      }
    }
  }
}