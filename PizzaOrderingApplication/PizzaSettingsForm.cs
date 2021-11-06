using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class PizzaSettingsForm : Form
    {
        public List<PizzaSize> sizes = new List<PizzaSize>();
        public List<PizzaTopping> toppings = new List<PizzaTopping>();

        public PizzaSettingsForm()
        {
            InitializeComponent();

            sizes.Add(new PizzaSize("Small", 5.5, 2));
            sizes.Add(new PizzaSize("Medium", 7.5, 3));
            sizes.Add(new PizzaSize("Large", 9.99, 4));

            toppings.Add(new PizzaTopping("Ham", 0.5));
            toppings.Add(new PizzaTopping("Bacon", 0.6));
            toppings.Add(new PizzaTopping("Pepperoni", 0.65));
            toppings.Add(new PizzaTopping("Salami", 0.5));
        }

        private void PizzaSettingsForm_Load(object sender, System.EventArgs e)
        {
            dataGridViewSizeSettings.DataSource = new BindingList<PizzaSize>(sizes);

            dataGridViewToppingsSettings.DataSource = new BindingList<PizzaTopping>(toppings);
        }

        public void GetSizeData()
        {
        }

        public void GetToppingData()
        {
        }

        private void buttonSaveSizes_Click(object sender, System.EventArgs e)
        {
            GetSizeData();

            var allSizesJson = JsonConvert.SerializeObject(sizes);
            File.WriteAllText("PizzaSizes.json", allSizesJson);

            MessageBox.Show("Successfully saved pizza sizes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveToppings_Click(object sender, System.EventArgs e)
        {
            var allToppingsJson = JsonConvert.SerializeObject(toppings);
            File.WriteAllText("PizzaToppings.json", allToppingsJson);

            MessageBox.Show("Successfully saved pizza toppings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PizzaSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Close Settings Form?");
        }
    }
}