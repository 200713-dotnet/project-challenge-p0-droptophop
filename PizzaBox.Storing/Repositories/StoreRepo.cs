using System;
using System.Collections.Generic;
using System.Linq;
using model = PizzaBox.Housing.Models;
using PizzaBox.Storing;

namespace PizzaBox.Storing.Repositories
{
    public class StoreRepo
    {
        private PizzaStoreDbContext _db = new PizzaStoreDbContext();

        public void CreateOrder(model.Order order, model.User user, model.Store store)
        {
            var newOrder = new Orders();

            newOrder.Price = order.PurchaseTotal();
            // newOrder.UserId = _db.Users.FirstOrDefault(u => u.Name == user.name);
            // newOrder.StoreId = _db.Store.FirstOrDefault(s => s.Name == store.name);

            // foreach(var pizza in order.Pizzas)
            // {
            //     newOrder.Pizza.Add(Create(pizza));
            // }
        }
    }
}