using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaBox.Housing.Components;

namespace PizzaBox.Housing.Models
{
  public class Pizza
  {
    private List<Topping> _toppings = new List<Topping>();
    public string Name { get; }
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings 
    { 
      get
      {
        return _toppings;
      } 
    }

/*            Constructor          */

    public Pizza()
    {}

    public Pizza(string name, List<Topping> toppings)
    {
      Name = name;
      Toppings.AddRange(toppings);
    }

    public Pizza(Crust crust, Size size, string name)
    {
      Crust = crust;
      Size = size;
      Name = name;
    }

/*            End Constructors           */


    public void Addtopping(Topping topping)
    {
      Toppings.Add(topping);
    }
    public void Addtoppings(List<Topping> toppings)
    {
      Toppings.AddRange(toppings);
    }

    public decimal Price()
    {
      return Crust.Price + Size.Price + Toppings.Sum(t => t.Price);
    }

    public override string ToString()
    {
      return $"{Size.Name} {Crust.Name} {Name}\nToppings: {string.Join(", ", Toppings.Select(t => t.Name).ToArray())}\nTotal Price: {Price()}";
    }
  }
}