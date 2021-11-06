using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class PizzaSettingsForm : Form
    {
        private List<PizzaSize> sizes = new List<PizzaSize>();
        private List<PizzaTopping> toppings = new List<PizzaTopping>();

        public List<PizzaSize> GetPizzaSizes { get { return sizes; } }
        public List<PizzaTopping> GetPizzaToppings { get { return toppings; } }

        public PizzaSettingsForm()
        {
            InitializeComponent();

            // Check for already existing size and topping data, load saved data
            GetSizeData();
            GetToppingData();

            // Bind the sizes and toppings lists to their Data Grids
            dataGridViewSizeSettings.DataSource = new BindingList<PizzaSize>(sizes);
            dataGridViewToppingsSettings.DataSource = new BindingList<PizzaTopping>(toppings);
        }

        // Get data from the JSON file and if it's not empty, get the size objects
        public void GetSizeData()
        {
            string sizesFromJson = ReadSizesFromJson();
            if (sizesFromJson != null)
                sizes = JsonConvert.DeserializeObject<List<PizzaSize>>(sizesFromJson);
        }

        // Get data from the JSON file and if it's not empty, get the topping objects
        public void GetToppingData()
        {
            string toppingsFromJson = ReadToppingsFromJson();
            if (toppingsFromJson != null)
                toppings = JsonConvert.DeserializeObject<List<PizzaTopping>>(toppingsFromJson);
        }

        // Save sizes to JSON file
        private void buttonSaveSizes_Click(object sender, System.EventArgs e)
        {
            GetSizeData();

            var allSizesJson = JsonConvert.SerializeObject(sizes);
            File.WriteAllText("PizzaSizes.json", allSizesJson);

            MessageBox.Show("Successfully saved pizza sizes.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Save toppings to JSON file
        private void buttonSaveToppings_Click(object sender, System.EventArgs e)
        {
            var allToppingsJson = JsonConvert.SerializeObject(toppings);
            File.WriteAllText("PizzaToppings.json", allToppingsJson);

            MessageBox.Show("Successfully saved pizza toppings.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PizzaSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Warning, check for unsaved data
            MessageBox.Show("Close Settings Form?");
        }

        // Read the JSON file to get size data
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

        // Read the JSON file to get topping data
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