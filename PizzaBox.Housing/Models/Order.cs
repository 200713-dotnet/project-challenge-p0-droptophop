using System;
using System.Collections.Generic;
using comp = PizzaBox.Housing.Components;
using System.Linq;

namespace PizzaBox.Housing.Models
{
  public class Order
  {
    private List<Pizza> _pizzas = new List<Pizza>();
    public List<Pizza> Pizzas { get { return _pizzas; } }

    public Pizza CreatePizza(string name, List<comp.Topping> toppings)
    {
      var pizza = new Pizza(name, toppings);

      Pizzas.Add(pizza);

      return pizza;
    }
    public decimal PurchaseTotal()
    {
      return Pizzas.Sum(p => p.Price());
    }
    public void DisplayOrder()
    {
      Console.WriteLine($"Purchase Total: {PurchaseTotal().ToString()}");
      foreach(var p in Pizzas)
      {
        Console.WriteLine(Pizzas);
      }
    }
  }
}