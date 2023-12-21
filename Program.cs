using System;
using System.Collections.Generic;
using Models;

public class OrderValue
{
    private Order order;

    public OrderValue(Order order)
    {
        this.order = order;
    }

    public static void Main()
    {
        //Create an inventory
        var inventory = new Dictionary<string, decimal>
        {
            {"apple", 5m},
            {"banana", 18m},
            {"orange", 51.43m},
            {"pork", 20.5m},
        };

        //Create a warehouse
        Warehouse warehouse = new Warehouse(inventory);

        //Create a customer
        Customer customer = new Customer(true);

        //Create an items array
        Item[] items = { new Item("apple", 1m, 0.5m), new Item("banana", 3m, 1.3m), new Item("pork", 5.5m, 10.7m)};

        //Create an order
        Order order = new Order(items, customer);

        // Calculate total cost
        decimal total = 0;
        foreach (Item item in order.items)
        {
            total += item.price * item.quantity;
        }

        //Apply discounts
        if (order.customer.hasDiscount) {
            total -= total * 0.1m;
        }

        //Update inventory
        foreach (Item item in order.items) {
            warehouse.updateInventory(item.id, -item.quantity);
        }

        Console.WriteLine("Total Cost: " + total);
    }
}