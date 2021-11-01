namespace PizzaOrderingApplication
{
    public class PizzaSize
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int FreeIngredients { get; set; }

        public PizzaSize()
        {
            // Default constructor for enabling new rows in DataGridView
        }

        public PizzaSize(string name, double price, int freeIngredients)
        {
            Name = name;
            Price = price;
            FreeIngredients = freeIngredients;
        }
    }
}