namespace CashRegApp
{
    public class ItemProperties //or as public interface
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ItemNumber { get; set; } //keep as string, or use int for multiple menus/txt files ; add item # for easy user selection?
        //public int Quantity { get; set; }

        public ItemProperties()
        {

        }

        public ItemProperties(string category, string name, decimal price, string description) //, int quantity
        {
            Name = name;
            Price = price;
            Description = description;
            ItemNumber = category;
            //Quantity = quantity;
        }
    }
}
