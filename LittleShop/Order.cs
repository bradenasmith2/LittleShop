using System;
using System.Collections.Generic;

namespace LittleShop
{
    public class Order
    {
        public Customer Customer;
        public List<Item> Items;
        public int TotalCost;

        public Order(Customer customer)
        {
            Customer = customer;
            Items = new List<Item>();
            TotalCost = 0;
        }

        public void AddToOrder(Item item)
        {
            Items.Add(item);
        }

        public int Total()
        {
            foreach (var item in Items)
            {
                TotalCost = item.Price + TotalCost;
            }
            return TotalCost;
        }
    }
}
