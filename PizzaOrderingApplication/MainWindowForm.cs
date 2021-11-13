using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class MainWindowForm : Form
    {
        private PizzaSettingsForm settingsForm = new PizzaSettingsForm();

        private const double extra = 0.75;

        private double basePrice = 0;
        private double extraPrice = 0;
        private double totalPrice = 0;

        private int ingredientCount = 0;
        private int freeIngredients = 0;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        public MainWindowForm(User loggedInUser)
        {
            InitializeComponent();

            // Set permission for size settings
            if (loggedInUser.CanEditSizes)
            {
                settingsForm.ShowSizeSettings = true;
            }
            else
            {
                settingsForm.ShowSizeSettings = false;
            }

            // Set permission for topping settings
            if (loggedInUser.CanEditToppings)
            {
                settingsForm.ShowToppingSettings = true;
            }
            else
            {
                settingsForm.ShowToppingSettings = false;
            }

            // Set permission for user settings
            if (loggedInUser.CanEditUsers)
            {
                settingsForm.ShowUserSettings = true;
            }
            else
            {
                settingsForm.ShowUserSettings = false;
            }

            // Disable all settings if user has none of the permissions
            if (!loggedInUser.CanEditSizes && !loggedInUser.CanEditToppings && !loggedInUser.CanEditUsers)
            {
                settingsToolStripMenuItem.Enabled = false;
            }
        }

        // Check for any previously saved data to create and show controls for sizes and toppings
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplaySizes();
            DisplayToppings();
        }

        // Function to enable GroupBoxes and Button
        private void Enable_Elements()
        {
            groupBoxIngredients.Enabled = true;
            groupBoxDelivery.Enabled = true;
            groupBoxPrice.Enabled = true;
            buttonOrder.Visible = true;
        }

        // Function to calculate and display total price
        private void Display_Price()
        {
            if (ingredientCount > freeIngredients)
            {
                extraPrice = (ingredientCount - freeIngredients) * extra;
            }
            else
            {
                extraPrice = 0;
            }

            totalPrice = basePrice + extraPrice;
            textBoxPrice.Text = $"{totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-DE"))}";
        }

        // Enable the rest of the GroupBoxes and the Button, and update the free ingredient label
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Enable_Elements();

            var radioButton = (sender as RadioButton);

            // TODO: name clashes with addition of price on radio button text
            PizzaSize selectedSize = settingsForm.GetPizzaSizes.Where(x => x.Name.Equals(radioButton.Text))
                                                               .FirstOrDefault();

            labelFree.Text = $"({selectedSize.FreeIngredients} free ingredients)";
            basePrice = selectedSize.Price;
            freeIngredients = selectedSize.FreeIngredients;

            Display_Price();
        }

        // Calculate selected ingredients and price according to a topping being checked or unchecked
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (sender as CheckBox);

            if (checkBox.Checked)
            {
                ingredientCount++;
            }
            if (!checkBox.Checked)
            {
                ingredientCount--;
            }

            Display_Price();
        }

        // Function to create and display controls for sizes
        public void DisplaySizes()
        {
            // Clear all controls to avoid repetition
            flowLayoutPanelSize.Controls.Clear();

            // Create new controls for every saved size
            foreach (var size in settingsForm.GetPizzaSizes)
            {
                var radioButton = new RadioButton();
                radioButton.Text = $"{size.Name}"; //({size.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-DE"))})";
                //radioButton.Width = (TextRenderer.MeasureText(radioButton.Text, radioButton.Font)).Width + 20;
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                flowLayoutPanelSize.Controls.Add(radioButton);
            }
        }

        // Function to create and display controls for toppings
        public void DisplayToppings()
        {
            // Clear all controls to avoid repetition
            flowLayoutPanelIngredients.Controls.Clear();

            // Create new controls for every saved topping
            foreach (var topping in settingsForm.GetPizzaToppings)
            {
                var checkBox = new CheckBox();
                checkBox.Text = topping.Name;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                flowLayoutPanelIngredients.Controls.Add(checkBox);
            }
        }

        // Function for when the Order button is clicked
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now.TimeOfDay;

            if (TimeSpan.TryParse(maskedTextBoxDelivery.Text, out TimeSpan deliveryTime))
            {
                if (deliveryTime > currentTime)
                {
                    var reply = MessageBox.Show($"The total for your pizza is {totalPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-DE"))} " +
                                                $"(to be delivered at {deliveryTime}), are you sure you want to order?",
                                                 "Confirm order",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);
                    if (reply == DialogResult.Yes)
                    {
                        MessageBox.Show("Your order is successful!",
                                        "Order completed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Your order was cancelled",
                                        "Order cancelled",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The time you gave is in the past. Please give a valid time in the future.",
                                    "Time in the past",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The time you gave is invalid. Please give a valid time.",
                                "Invalid time",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Function for when the Settings menu item is clicked
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentCheckedRadioButton = flowLayoutPanelSize.Controls.OfType<RadioButton>()
                                                                        .FirstOrDefault(x => x.Checked == true);

            settingsForm.ShowDialog();

            // TODO: Radio button after settings form is closed does not remain checked
            if (currentCheckedRadioButton != null)
            {
                currentCheckedRadioButton.Checked = false;
                currentCheckedRadioButton.Checked = true;
            }

            // Update sizes and toppings when settings form is closed
            DisplaySizes();
            DisplayToppings();
        }

        // Function for when the About menu item is clicked
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Text = "About Window";
            aboutWindow.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}