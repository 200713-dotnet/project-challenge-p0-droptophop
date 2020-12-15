using PizzaBox.Housing.Abstracts;

namespace PizzaBox.Housing.Components
{
    public class Size: PizzaComponent
    {
        public Size()
        {}

        public Size(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}