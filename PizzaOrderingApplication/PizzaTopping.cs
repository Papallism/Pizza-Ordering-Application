namespace PizzaOrderingApplication
{
    internal class PizzaTopping
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public PizzaTopping(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}