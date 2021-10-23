using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class Form1 : Form
    {
        private const double priceSmall = 5.5;
        private const double priceMedium = 11.75;
        private const double priceLarge = 15.0;
        private const double extra = 0.75;

        private const int freeSmall = 2;
        private const int freeMedium = 3;
        private const int freeLarge = 4;

        private static double basePrice = 0;
        private static double extraPrice = 0;
        private static double totalPrice = 0;

        private static int ingredientCount = 0;
        private static int freeIngredients = 0;

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

        private readonly TimeSpan currentTime = DateTime.Now.TimeOfDay;

        public Form1()
        {
            InitializeComponent();
        }

        // Enable GroupBoxes and Button
        private void Enable_Elements()
        {
            groupBoxIngredients.Enabled = true;
            groupBoxDelivery.Enabled = true;
            groupBoxPrice.Enabled = true;
            buttonOrder.Visible = true;
        }

        // Calculate and display total price
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

        // Create, name and show controls (radio buttons and check boxes)
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sizeText.Count; i++)
            {
                RadioButton radioButton = new();
                radioButton.Text = sizeText[i];
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                flowLayoutPanelSize.Controls.Add(radioButton);
            }

            for (int i = 0; i < ingredientText.Count; i++)
            {
                CheckBox checkBox = new();
                checkBox.Text = ingredientText[i];
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                flowLayoutPanelIngredients.Controls.Add(checkBox);
            }
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

        private void buttonOrder_Click(object sender, EventArgs e)
        {
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
    }
}