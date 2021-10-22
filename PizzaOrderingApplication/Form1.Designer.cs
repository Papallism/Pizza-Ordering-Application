
namespace PizzaOrderingApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.groupBoxIngredients = new System.Windows.Forms.GroupBox();
            this.groupBoxDelivery = new System.Windows.Forms.GroupBox();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelDelivery = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.maskedTextBoxDelivery = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxIngredients.SuspendLayout();
            this.groupBoxDelivery.SuspendLayout();
            this.groupBoxPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(231, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(338, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Welcome to UNIC pizza";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaOrderingApplication.Properties.Resources.Pizza_Banner;
            this.pictureBox1.Location = new System.Drawing.Point(-145, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizzaOrderingApplication.Properties.Resources.Pizza_Banner;
            this.pictureBox2.Location = new System.Drawing.Point(588, -8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(356, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtitle.Location = new System.Drawing.Point(259, 53);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(281, 30);
            this.labelSubtitle.TabIndex = 3;
            this.labelSubtitle.Text = "We deliver to your classroom";
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.labelSize);
            this.groupBoxSize.Location = new System.Drawing.Point(64, 143);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(147, 164);
            this.groupBoxSize.TabIndex = 4;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // groupBoxIngredients
            // 
            this.groupBoxIngredients.Controls.Add(this.labelIngredients);
            this.groupBoxIngredients.Location = new System.Drawing.Point(247, 143);
            this.groupBoxIngredients.Name = "groupBoxIngredients";
            this.groupBoxIngredients.Size = new System.Drawing.Size(304, 164);
            this.groupBoxIngredients.TabIndex = 5;
            this.groupBoxIngredients.TabStop = false;
            this.groupBoxIngredients.Text = "Ingredients";
            // 
            // groupBoxDelivery
            // 
            this.groupBoxDelivery.Controls.Add(this.maskedTextBoxDelivery);
            this.groupBoxDelivery.Controls.Add(this.labelDelivery);
            this.groupBoxDelivery.Location = new System.Drawing.Point(587, 143);
            this.groupBoxDelivery.Name = "groupBoxDelivery";
            this.groupBoxDelivery.Size = new System.Drawing.Size(147, 80);
            this.groupBoxDelivery.TabIndex = 6;
            this.groupBoxDelivery.TabStop = false;
            this.groupBoxDelivery.Text = "Delivery";
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.textBoxPrice);
            this.groupBoxPrice.Controls.Add(this.labelPrice);
            this.groupBoxPrice.Location = new System.Drawing.Point(587, 227);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(147, 80);
            this.groupBoxPrice.TabIndex = 7;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Price";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrder.Location = new System.Drawing.Point(325, 358);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(150, 50);
            this.buttonOrder.TabIndex = 8;
            this.buttonOrder.Text = "Place Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(7, 23);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(63, 15);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Select size:";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(7, 23);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(103, 15);
            this.labelIngredients.TabIndex = 0;
            this.labelIngredients.Text = "Select ingredients:";
            // 
            // labelDelivery
            // 
            this.labelDelivery.AutoSize = true;
            this.labelDelivery.Location = new System.Drawing.Point(7, 23);
            this.labelDelivery.Name = "labelDelivery";
            this.labelDelivery.Size = new System.Drawing.Size(112, 15);
            this.labelDelivery.TabIndex = 0;
            this.labelDelivery.Text = "Select delivery time:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(7, 23);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(64, 15);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Total price:";
            // 
            // maskedTextBoxDelivery
            // 
            this.maskedTextBoxDelivery.Location = new System.Drawing.Point(7, 41);
            this.maskedTextBoxDelivery.Mask = "00:00";
            this.maskedTextBoxDelivery.Name = "maskedTextBoxDelivery";
            this.maskedTextBoxDelivery.Size = new System.Drawing.Size(112, 23);
            this.maskedTextBoxDelivery.TabIndex = 1;
            this.maskedTextBoxDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxDelivery.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(7, 41);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(112, 23);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.groupBoxPrice);
            this.Controls.Add(this.groupBoxDelivery);
            this.Controls.Add(this.groupBoxIngredients);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxIngredients.ResumeLayout(false);
            this.groupBoxIngredients.PerformLayout();
            this.groupBoxDelivery.ResumeLayout(false);
            this.groupBoxDelivery.PerformLayout();
            this.groupBoxPrice.ResumeLayout(false);
            this.groupBoxPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.GroupBox groupBoxIngredients;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.GroupBox groupBoxDelivery;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDelivery;
        private System.Windows.Forms.Label labelDelivery;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonOrder;
    }
}

