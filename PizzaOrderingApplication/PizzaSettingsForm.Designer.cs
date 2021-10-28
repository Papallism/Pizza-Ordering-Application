
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
            this.groupBoxSizeSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxToppingsSettings = new System.Windows.Forms.GroupBox();
            this.buttonSaveSizes = new System.Windows.Forms.Button();
            this.buttonResetSizes = new System.Windows.Forms.Button();
            this.buttonSaveToppings = new System.Windows.Forms.Button();
            this.buttonResetToppings = new System.Windows.Forms.Button();
            this.dataGridViewSizeSettings = new System.Windows.Forms.DataGridView();
            this.dataGridViewToppingsSettings = new System.Windows.Forms.DataGridView();
            this.groupBoxSizeSettings.SuspendLayout();
            this.groupBoxToppingsSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSizeSettings)).BeginInit();
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
            // buttonSaveSizes
            // 
            this.buttonSaveSizes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveSizes.Location = new System.Drawing.Point(64, 390);
            this.buttonSaveSizes.Name = "buttonSaveSizes";
            this.buttonSaveSizes.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveSizes.TabIndex = 0;
            this.buttonSaveSizes.Text = "Save";
            this.buttonSaveSizes.UseVisualStyleBackColor = true;
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
            // buttonSaveToppings
            // 
            this.buttonSaveToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveToppings.Location = new System.Drawing.Point(60, 390);
            this.buttonSaveToppings.Name = "buttonSaveToppings";
            this.buttonSaveToppings.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveToppings.TabIndex = 0;
            this.buttonSaveToppings.Text = "Save";
            this.buttonSaveToppings.UseVisualStyleBackColor = true;
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
            // dataGridViewSizeSettings
            // 
            this.dataGridViewSizeSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSizeSettings.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewSizeSettings.Name = "dataGridViewSizeSettings";
            this.dataGridViewSizeSettings.RowTemplate.Height = 25;
            this.dataGridViewSizeSettings.Size = new System.Drawing.Size(366, 362);
            this.dataGridViewSizeSettings.TabIndex = 2;
            // 
            // dataGridViewToppingsSettings
            // 
            this.dataGridViewToppingsSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToppingsSettings.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewToppingsSettings.Name = "dataGridViewToppingsSettings";
            this.dataGridViewToppingsSettings.RowTemplate.Height = 25;
            this.dataGridViewToppingsSettings.Size = new System.Drawing.Size(366, 362);
            this.dataGridViewToppingsSettings.TabIndex = 2;
            // 
            // PizzaSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxToppingsSettings);
            this.Controls.Add(this.groupBoxSizeSettings);
            this.Name = "PizzaSettingsForm";
            this.Text = "PizzaSettingsForm";
            this.groupBoxSizeSettings.ResumeLayout(false);
            this.groupBoxToppingsSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSizeSettings)).EndInit();
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
    }
}