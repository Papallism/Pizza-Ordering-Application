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

            string sizesFromJson = ReadSizesFromJson();
            if (sizesFromJson != null)
                sizes = JsonConvert.DeserializeObject<List<PizzaSize>>(sizesFromJson);

            string toppingsFromJson = ReadToppingsFromJson();
            if (toppingsFromJson != null)
                toppings = JsonConvert.DeserializeObject<List<PizzaTopping>>(toppingsFromJson);

            dataGridViewSizeSettings.DataSource = new BindingList<PizzaSize>(sizes);
            dataGridViewToppingsSettings.DataSource = new BindingList<PizzaTopping>(toppings);
        }

        private void PizzaSettingsForm_Load(object sender, System.EventArgs e)
        {
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

        private string ReadSizesFromJson()
        {
            try
            {
                return File.ReadAllText("PizzaSizes.json");
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        private string ReadToppingsFromJson()
        {
            try
            {
                return File.ReadAllText("PizzaToppings.json");
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
    }
}