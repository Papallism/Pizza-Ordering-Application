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
        private List<User> users = new List<User>();

        public List<PizzaSize> GetPizzaSizes
        { get { return sizes; } }

        public List<PizzaTopping> GetPizzaToppings
        { get { return toppings; } }

        public PizzaSettingsForm()
        {
            InitializeComponent();

            // Check for already existing size and topping data, load saved data
            GetSizeData();
            GetToppingData();
            GetUserData();

            // Bind the sizes and toppings lists to their Data Grids
            dataGridViewSizeSettings.DataSource = new BindingList<PizzaSize>(sizes);
            dataGridViewToppingsSettings.DataSource = new BindingList<PizzaTopping>(toppings);
            dataGridViewUserSettings.DataSource = new BindingList<User>(users);
        }

        // Get data from the JSON file and if it's not empty, get the size objects
        private void GetSizeData()
        {
            string sizesFromJson = ReadSizesFromJson();
            if (sizesFromJson != null)
                sizes = JsonConvert.DeserializeObject<List<PizzaSize>>(sizesFromJson);
        }

        // Get data from the JSON file and if it's not empty, get the topping objects
        private void GetToppingData()
        {
            string toppingsFromJson = ReadToppingsFromJson();
            if (toppingsFromJson != null)
                toppings = JsonConvert.DeserializeObject<List<PizzaTopping>>(toppingsFromJson);
        }

        // If saved users exist, deserialize them into the list
        private void GetUserData()
        {
            string userDataFromJson = ReadUsersFromJson();
            if (userDataFromJson != null)
            {
                users = JsonConvert.DeserializeObject<List<User>>(userDataFromJson);
            }
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
        }// Read the JSON file for any saved users or return null

        private string ReadUsersFromJson()
        {
            try
            {
                return File.ReadAllText("PizzaUsers.json");
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        // When Reset is clicked, load the previously saved data from the JSON file and rebind the list
        private void buttonResetSizes_Click(object sender, System.EventArgs e)
        {
            GetSizeData();
            dataGridViewSizeSettings.DataSource = new BindingList<PizzaSize>(sizes);
        }

        // When Reset is clicked, load the previously saved data from the JSON file and rebind the list
        private void buttonResetToppings_Click(object sender, System.EventArgs e)
        {
            GetToppingData();
            dataGridViewToppingsSettings.DataSource = new BindingList<PizzaTopping>(toppings);
        }

        // When Reset is clicked, load the previously saved data from the JSON file and rebind the list
        private void buttonResetUser_Click(object sender, System.EventArgs e)
        {
            GetUserData();
            dataGridViewUserSettings.DataSource = new BindingList<User>(users);
        }

        // On form closing, load the saved data from JSON files and rebind the lists to handle unwanted changes
        private void PizzaSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetSizeData();
            GetToppingData();
            GetUserData();

            dataGridViewSizeSettings.DataSource = new BindingList<PizzaSize>(sizes);
            dataGridViewToppingsSettings.DataSource = new BindingList<PizzaTopping>(toppings);
            dataGridViewUserSettings.DataSource = new BindingList<User>(users);
        }

        // Save sizes to JSON file
        private void buttonSaveSizes_Click(object sender, System.EventArgs e)
        {
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

        // Save users to JSON file
        private void buttonSaveUser_Click(object sender, System.EventArgs e)
        {
            var allUsersJson = JsonConvert.SerializeObject(users);
            File.WriteAllText("PizzaUsers.json", allUsersJson);

            MessageBox.Show("Successfully saved users.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}