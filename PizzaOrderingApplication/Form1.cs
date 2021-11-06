using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class Form1 : Form
    {
        private PizzaSettingsForm settingsForm = new PizzaSettingsForm();

        private const double priceSmall = 5.5;
        private const double priceMedium = 11.75;
        private const double priceLarge = 15.0;
        private const double extra = 0.75;

        private const int freeSmall = 2;
        private const int freeMedium = 3;
        private const int freeLarge = 4;

        private double basePrice = 0;
        private double extraPrice = 0;
        private double totalPrice = 0;

        private int ingredientCount = 0;
        private int freeIngredients = 0;

        private readonly List<string> sizeText = new()
        {
            "Small",
            "Medium",
            "Large",
        };

        private readonly List<string> ingredientText = new()
        {
            "Pepperoni",
            "Mushroom",
            "Onion",
            "Ham",
            "Bacon",
            "Pepper",
            "Feta",
            "Olives",
            "Chicken",
            "Parmesan",
            "Mozzarella",
            "Corn",
            "Chili",
            "Jalapeno",
            "Beef",
            "Turkey",
            "Oregano",
            "Rocket",
            "Prosciutto",
            "Blue cheese",
            "Halloumi",
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Function to create, name and show controls (radio buttons and check boxes)
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
            if (radioButton.Text.Equals(sizeText[0]))
            {
                labelFree.Text = $"({freeSmall} free ingredients)";
                basePrice = priceSmall;
                freeIngredients = freeSmall;
            }
            if (radioButton.Text.Equals(sizeText[1]))
            {
                labelFree.Text = $"({freeMedium} free ingredients)";
                basePrice = priceMedium;
                freeIngredients = freeMedium;
            }
            if (radioButton.Text.Equals(sizeText[2]))
            {
                labelFree.Text = $"({freeLarge} free ingredients)";
                basePrice = priceLarge;
                freeIngredients = freeLarge;
            }
            Display_Price();
        }

        // Calculate selected ingredients and price accordingly
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

        public void DisplaySizes()
        {
            flowLayoutPanelSize.Controls.Clear();

            foreach (var size in settingsForm.sizes)
            {
                var radioButton = new RadioButton();
                radioButton.Text = size.Name;
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                flowLayoutPanelSize.Controls.Add(radioButton);
            }
        }

        public void DisplayToppings()
        {
            flowLayoutPanelIngredients.Controls.Clear();

            foreach (var topping in settingsForm.toppings)
            {
                var checkBox = new CheckBox();
                checkBox.Text = topping.Name;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                flowLayoutPanelIngredients.Controls.Add(checkBox);
            }
        }

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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();

            DisplaySizes();
            DisplayToppings();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Text = "About Window";
            aboutWindow.ShowDialog();
        }
    }
}