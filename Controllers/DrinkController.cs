using System;
using csharp_burgershack.Services;

namespace csharp_burgershack.Controllers
{
  public class DrinkController
  {
    private DrinkService _drinkService { get; set; } = new DrinkService();


    public void UserInput()
    {
      _drinkService.GetDrinks();
      Print();
      string choice = Console.ReadLine().ToLower();
      Console.Clear();
      switch (choice)
      {
        case "q":
          Environment.Exit(1);
          break;
        default:
          if (int.TryParse(choice, out int index))
          {
            //print out drink details
            _drinkService.GetDrinks(index - 1);
            Print();
            Console.ReadKey();
            Console.Clear();
          }
          else
          {
            Console.WriteLine("invalid command");
          }
          break;
      }

    }
    private void Print()
    {
      foreach (string message in _drinkService.Messages)
      {
        Console.WriteLine(message);
      }
      _drinkService.Messages.Clear();
      Console.WriteLine("Type a number to see details or Q to quit");
    }
  }
}