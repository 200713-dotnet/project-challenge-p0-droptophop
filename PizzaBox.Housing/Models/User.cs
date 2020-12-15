using System.Collections.Generic;

namespace PizzaBox.Housing.Models
{
  public class User
  {
    private List<Order> _orders = new List<Order>();

    public string name { get; set; }
    public List<Order> Orders { get { return _orders; } }
  }
}