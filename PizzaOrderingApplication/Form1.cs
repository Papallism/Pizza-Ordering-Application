using System;
using System.Collections.Generic;
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

        private static int ingredientCount = 0;
        private static int freeIngredients = 0;

        private readonly List<string> sizeText = new()
        {
            "Small",
            "Medium",
            "Large"
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
            "Halloumi"
        };

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

        // Display total price
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

            textBoxPrice.Text = $"€ {basePrice + extraPrice}";
        }

        // Create, name and show controls (radio buttons and check boxes)
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sizeText.Count; i++)
            {
                var radioButton = new RadioButton();
                radioButton.Text = sizeText[i];
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                flowLayoutPanelSize.Controls.Add(radioButton);
            }

            for (int i = 0; i < ingredientText.Count; i++)
            {
                var checkBox = new CheckBox();
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
    }
}