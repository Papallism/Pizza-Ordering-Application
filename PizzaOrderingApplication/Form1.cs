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

        public Form1()
        {
            InitializeComponent();
        }

        private void Enable_Elements()
        {
            groupBoxIngredients.Enabled = true;
            groupBoxDelivery.Enabled = true;
            groupBoxPrice.Enabled = true;
            buttonOrder.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sizeText = new List<string> { "Small", "Medium", "Large" };
            var ingredientText = new List<string> { "Pepperoni", "Mushroom", "Onion", "Ham", "Bacon", "Pepper", "Feta",
                                                    "Olives", "Chicken", "Parmesan", "Mozzarella", "Corn", "Chili", "Jalapeno",
                                                    "Beef", "Turkey", "Oregano", "Rocket", "Prosciutto", "Blue cheese", "Halloumi" };

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
                flowLayoutPanelIngredients.Controls.Add(checkBox);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //var radioButton = (sender as RadioButton);
            Enable_Elements();
        }
    }
}