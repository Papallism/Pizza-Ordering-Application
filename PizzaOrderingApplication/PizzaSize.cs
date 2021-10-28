namespace PizzaOrderingApplication
{
    internal class PizzaSize
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public PizzaSize(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}