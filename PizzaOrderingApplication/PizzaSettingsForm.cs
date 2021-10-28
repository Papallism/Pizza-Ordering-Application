using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class PizzaSettingsForm : Form
    {
        private List<PizzaSize> sizes = new List<PizzaSize>();
        private List<PizzaTopping> toppings = new List<PizzaTopping>();

        public PizzaSettingsForm()
        {
            InitializeComponent();

            sizes.Add(new PizzaSize("Small", 5.50));
            sizes.Add(new PizzaSize("Medium", 11.75));
            sizes.Add(new PizzaSize("Large", 15.00));

            dataGridViewSizeSettings.DataSource = new BindingList<PizzaSize>(sizes);

            toppings.Add(new PizzaTopping("Mushrooms", 0.75));
            toppings.Add(new PizzaTopping("Peppers", 1.25));
            toppings.Add(new PizzaTopping("Onions", 1));

            dataGridViewToppingsSettings.DataSource = new BindingList<PizzaTopping>(toppings);
        }
    }
}