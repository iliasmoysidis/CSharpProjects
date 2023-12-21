namespace Models
{
    public class Item
    {
        public string id;
        public decimal quantity;
        public decimal price;

        public Item(string id, decimal quantity, decimal price)
        {
            this.id = id;
            this.quantity = quantity;
            this.price = price;
        }
    }
}