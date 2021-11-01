namespace PizzaOrderingApplication
{
    public class PizzaTopping
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public PizzaTopping()
        {
            // Default constructor for enabling new rows in DataGridView
        }

        public PizzaTopping(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}