using System;
using model = PizzaBox.Housing.Models;
using comp = PizzaBox.Housing.Components;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Leaning Tower of Pizza!");

      // var pr = new PizzaRepo();
      // var pizza = new model.Pizza()
      // {
      //   Name = "Chicken Pizza",
      //   Crust = new comp.Crust() { Name = "Deep Dish"} ,
      //   Size = new comp.Size() { Name = "Large" }
      // };
      
      // pr.Create(pizza);
      
      // Console.ReadLine();

      // foreach(var item in pr.CrustOptions())
      // {
      //   Console.WriteLine(item.Name);
      // }
      

      // foreach (var item in pr.ReadAll())
      // {
      //   System.Console.WriteLine(item); 
      // }
    }
  }
}