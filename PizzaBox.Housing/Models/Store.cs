using System;
using System.Collections.Generic;
using comp = PizzaBox.Housing.Components;

namespace PizzaBox.Housing.Models
{
  public class Store
  {
    public List<comp.Size> Sizes = new List<comp.Size>();
    public List<comp.Topping> Toppings = new List<comp.Topping>();
    public List<comp.Crust> Crusts = new List<comp.Crust>();
    public List<Order> Orders = new List<Order>();
    public string Name { get; set; }


/*                Constructors                          */


    public Store()
    {}

    public Store(string name)
    {
      Name = name;
    }

    public Store(List<comp.Topping> toppings, List<comp.Size> sizes, List<comp.Crust> crusts)
    {
      Toppings.AddRange(toppings);
      Sizes.AddRange(sizes);
      Crusts.AddRange(crusts);
    }


/*                End Constructors                          */



    public void DisplayMenu()
    {
      // TODO: Create Menu Logic
    }
    
    public Order CreateOrder(User user)
    {
      try
      {
        var order = new Order();

        user.Orders.Add(order);
        Orders.Add(order);

        return order;
      }
      catch
      { throw new System.Exception("Oops, We messed up..."); }
      finally { GC.Collect(); }
    }

    public Pizza CreatePizza(string name, List<comp.Topping> toppings, Order order)
    {
      return order.CreatePizza(name, toppings);
    }








  }
}