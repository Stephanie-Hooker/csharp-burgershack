using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.Services
{
  public class DrinkService
  {
    public List<Drink> Drinks { get; private set; }























    public DrinkService() //constructor
    {
      Drinks = new List<Drink>();
    }
  }
}