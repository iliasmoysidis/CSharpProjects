using Models;

namespace Models
{
    public class Order
    {
        public Item[] items;
        public Customer customer; 

        public Order(Item[] items, Customer customer)
        {
            this.items = items;
            this.customer = customer;
        }
    }
}