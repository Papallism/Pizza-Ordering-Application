
namespace PizzaOrderingApplication
{
    partial class PizzaSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaSettingsForm));
            this.groupBoxSizeSettings = new System.Windows.Forms.GroupBox();
            this.dataGridViewSizeSettings = new System.Windows.Forms.DataGridView();
            this.sizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeFreeIngredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonResetSizes = new System.Windows.Forms.Button();
            this.buttonSaveSizes = new System.Windows.Forms.Button();
            this.groupBoxToppingsSettings = new System.Windows.Forms.GroupBox();
            this.dataGridViewToppingsSettings = new System.Windows.Forms.DataGridView();
            this.toppingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toppingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonResetToppings = new System.Windows.Forms.Button();
            this.buttonSaveToppings = new System.Windows.Forms.Button();
            this.groupBoxSizeSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSizeSettings)).BeginInit();
            this.groupBoxToppingsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToppingsSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSizeSettings
            // 
            this.groupBoxSizeSettings.Controls.Add(this.dataGridViewSizeSettings);
            this.groupBoxSizeSettings.Controls.Add(this.buttonResetSizes);
            this.groupBoxSizeSettings.Controls.Add(this.buttonSaveSizes);
            this.groupBoxSizeSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSizeSettings.Name = "groupBoxSizeSettings";
            this.groupBoxSizeSettings.Size = new System.Drawing.Size(378, 426);
            this.groupBoxSizeSettings.TabIndex = 0;
            this.groupBoxSizeSettings.TabStop = false;
            this.groupBoxSizeSettings.Text = "Sizes";
            // 
            // dataGridViewSizeSettings
            // 
            this.dataGridViewSizeSettings.AllowDrop = true;
            this.dataGridViewSizeSettings.AllowUserToOrderColumns = true;
            this.dataGridViewSizeSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSizeSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sizeName,
            this.sizePrice,
            this.sizeFreeIngredients});
            this.dataGridViewSizeSettings.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewSizeSettings.Name = "dataGridViewSizeSettings";
            this.dataGridViewSizeSettings.RowTemplate.Height = 25;
            this.dataGridViewSizeSettings.Size = new System.Drawing.Size(366, 362);
            this.dataGridViewSizeSettings.TabIndex = 2;
            // 
            // sizeName
            // 
            this.sizeName.Frozen = true;
            this.sizeName.HeaderText = "Name";
            this.sizeName.Name = "sizeName";
            // 
            // sizePrice
            // 
            this.sizePrice.Frozen = true;
            this.sizePrice.HeaderText = "Price";
            this.sizePrice.Name = "sizePrice";
            // 
            // sizeFreeIngredients
            // 
            this.sizeFreeIngredients.Frozen = true;
            this.sizeFreeIngredients.HeaderText = "Free Ingredients";
            this.sizeFreeIngredients.Name = "sizeFreeIngredients";
            // 
            // buttonResetSizes
            // 
            this.buttonResetSizes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetSizes.Location = new System.Drawing.Point(215, 390);
            this.buttonResetSizes.Name = "buttonResetSizes";
            this.buttonResetSizes.Size = new System.Drawing.Size(100, 30);
            this.buttonResetSizes.TabIndex = 1;
            this.buttonResetSizes.Text = "Reset";
            this.buttonResetSizes.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSizes
            // 
            this.buttonSaveSizes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveSizes.Location = new System.Drawing.Point(64, 390);
            this.buttonSaveSizes.Name = "buttonSaveSizes";
            this.buttonSaveSizes.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveSizes.TabIndex = 0;
            this.buttonSaveSizes.Text = "Save";
            this.buttonSaveSizes.UseVisualStyleBackColor = true;
            this.buttonSaveSizes.Click += new System.EventHandler(this.buttonSaveSizes_Click);
            // 
            // groupBoxToppingsSettings
            // 
            this.groupBoxToppingsSettings.Controls.Add(this.dataGridViewToppingsSettings);
            this.groupBoxToppingsSettings.Controls.Add(this.buttonResetToppings);
            this.groupBoxToppingsSettings.Controls.Add(this.buttonSaveToppings);
            this.groupBoxToppingsSettings.Location = new System.Drawing.Point(410, 12);
            this.groupBoxToppingsSettings.Name = "groupBoxToppingsSettings";
            this.groupBoxToppingsSettings.Size = new System.Drawing.Size(378, 426);
            this.groupBoxToppingsSettings.TabIndex = 1;
            this.groupBoxToppingsSettings.TabStop = false;
            this.groupBoxToppingsSettings.Text = "Toppings";
            // 
            // dataGridViewToppingsSettings
            // 
            this.dataGridViewToppingsSettings.AllowDrop = true;
            this.dataGridViewToppingsSettings.AllowUserToOrderColumns = true;
            this.dataGridViewToppingsSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToppingsSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toppingName,
            this.toppingPrice});
            this.dataGridViewToppingsSettings.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewToppingsSettings.Name = "dataGridViewToppingsSettings";
            this.dataGridViewToppingsSettings.RowTemplate.Height = 25;
            this.dataGridViewToppingsSettings.Size = new System.Drawing.Size(366, 362);
            this.dataGridViewToppingsSettings.TabIndex = 2;
            // 
            // toppingName
            // 
            this.toppingName.Frozen = true;
            this.toppingName.HeaderText = "Name";
            this.toppingName.Name = "toppingName";
            // 
            // toppingPrice
            // 
            this.toppingPrice.Frozen = true;
            this.toppingPrice.HeaderText = "Price";
            this.toppingPrice.Name = "toppingPrice";
            // 
            // buttonResetToppings
            // 
            this.buttonResetToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResetToppings.Location = new System.Drawing.Point(218, 390);
            this.buttonResetToppings.Name = "buttonResetToppings";
            this.buttonResetToppings.Size = new System.Drawing.Size(100, 30);
            this.buttonResetToppings.TabIndex = 1;
            this.buttonResetToppings.Text = "Reset";
            this.buttonResetToppings.UseVisualStyleBackColor = true;
            // 
            // buttonSaveToppings
            // 
            this.buttonSaveToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveToppings.Location = new System.Drawing.Point(60, 390);
            this.buttonSaveToppings.Name = "buttonSaveToppings";
            this.buttonSaveToppings.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveToppings.TabIndex = 0;
            this.buttonSaveToppings.Text = "Save";
            this.buttonSaveToppings.UseVisualStyleBackColor = true;
            this.buttonSaveToppings.Click += new System.EventHandler(this.buttonSaveToppings_Click);
            // 
            // PizzaSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxToppingsSettings);
            this.Controls.Add(this.groupBoxSizeSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PizzaSettingsForm";
            this.Text = "Settings Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PizzaSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.PizzaSettingsForm_Load);
            this.groupBoxSizeSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSizeSettings)).EndInit();
            this.groupBoxToppingsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToppingsSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSizeSettings;
        private System.Windows.Forms.DataGridView dataGridViewSizeSettings;
        private System.Windows.Forms.Button buttonResetSizes;
        private System.Windows.Forms.Button buttonSaveSizes;
        private System.Windows.Forms.GroupBox groupBoxToppingsSettings;
        private System.Windows.Forms.DataGridView dataGridViewToppingsSettings;
        private System.Windows.Forms.Button buttonResetToppings;
        private System.Windows.Forms.Button buttonSaveToppings;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeFreeIngredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn toppingPrice;
    }
}