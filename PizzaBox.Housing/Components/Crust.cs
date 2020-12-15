using PizzaBox.Housing.Abstracts;

namespace PizzaBox.Housing.Components
{
    public class Crust: PizzaComponent
    {
        public Crust()
        {}

        public Crust(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}