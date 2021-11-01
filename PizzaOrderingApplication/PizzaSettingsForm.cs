using Newtonsoft.Json;
using System.Collections.Generic;
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
        }

        private void PizzaSettingsForm_Load(object sender, System.EventArgs e)
        {
        }

        public void GetSizeData()
        {
            foreach (DataGridViewRow row in dataGridViewSizeSettings.Rows)
            {
                if (row.Index == dataGridViewSizeSettings.Rows.Count - 1)
                {
                    break;
                }
                var sizeName = row.Cells["sizeName"].Value.ToString();
                var sizePrice = double.Parse(row.Cells["sizePrice"].Value.ToString());
                var sizeFreeIngredients = int.Parse(row.Cells["sizeFreeIngredients"].Value.ToString());

                sizes.Add(new PizzaSize(sizeName, sizePrice, sizeFreeIngredients));
            }
        }

        public void GetToppingData()
        {
            foreach (DataGridViewRow row in dataGridViewToppingsSettings.Rows)
            {
                if (row.Index == dataGridViewToppingsSettings.Rows.Count - 1)
                {
                    break;
                }
                var sizeName = row.Cells["toppingName"].Value.ToString();
                var sizePrice = double.Parse(row.Cells["toppingPrice"].Value.ToString());

                toppings.Add(new PizzaTopping(sizeName, sizePrice));
            }
        }

        private void buttonSaveSizes_Click(object sender, System.EventArgs e)
        {
            GetSizeData();

            var allSizesJson = JsonConvert.SerializeObject(sizes);
            File.WriteAllText("sizes.json", allSizesJson);

            MessageBox.Show("Successfully saved pizza sizes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveToppings_Click(object sender, System.EventArgs e)
        {
            GetToppingData();

            var allToppingsJson = JsonConvert.SerializeObject(toppings);
            File.WriteAllText("toppings.json", allToppingsJson);

            MessageBox.Show("Successfully saved pizza toppings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PizzaSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}