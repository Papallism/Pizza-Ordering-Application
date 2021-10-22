using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaOrderingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                flowLayoutPanelSize.Controls.Add(radioButton);
            }

            for (int i = 0; i < ingredientText.Count; i++)
            {
                var checkBox = new CheckBox();
                checkBox.Text = ingredientText[i];
                flowLayoutPanelIngredients.Controls.Add(checkBox);
            }
        }
    }
}