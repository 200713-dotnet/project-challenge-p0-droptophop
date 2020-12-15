using PizzaBox.Housing.Abstracts;

namespace PizzaBox.Housing.Components
{
    public class Topping: PizzaComponent
    {
        public Topping(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}