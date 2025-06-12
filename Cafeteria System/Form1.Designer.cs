namespace Cafeteria_System
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
            cmbCategory = new ComboBox();
            dataGridViewOrderItems = new DataGridView();
            btnAdd = new Button();
            dataGridViewProducts = new DataGridView();
            btnCheckout = new Button();
            nudQuantity = new NumericUpDown();
            lblTotal = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.ControlLightLight;
            cmbCategory.ForeColor = Color.DarkRed;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(243, 73);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(369, 33);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged_1;
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.BackgroundColor = Color.RosyBrown;
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(668, 132);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.RowHeadersWidth = 62;
            dataGridViewOrderItems.Size = new Size(585, 397);
            dataGridViewOrderItems.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightCoral;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(45, 626);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 68);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add to order";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = Color.RosyBrown;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(45, 132);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 62;
            dataGridViewProducts.Size = new Size(530, 454);
            dataGridViewProducts.TabIndex = 5;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.LightCoral;
            btnCheckout.Location = new Point(1137, 561);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(116, 53);
            btnCheckout.TabIndex = 6;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.White;
            nudQuantity.ForeColor = Color.DarkRed;
            nudQuantity.Location = new Point(271, 646);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(160, 31);
            nudQuantity.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F);
            lblTotal.ForeColor = Color.DarkRed;
            lblTotal.Location = new Point(893, 571);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 30);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Checkout";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(34, 70);
            label3.Name = "label3";
            label3.Size = new Size(181, 32);
            label3.TabIndex = 10;
            label3.Text = "Select Category";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 750);
            Controls.Add(label3);
            Controls.Add(lblTotal);
            Controls.Add(nudQuantity);
            Controls.Add(btnCheckout);
            Controls.Add(dataGridViewProducts);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewOrderItems);
            Controls.Add(cmbCategory);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private DataGridView dataGridViewOrderItems;
        private Button btnAdd;
        private DataGridView dataGridViewProducts;
        private Button btnCheckout;
        private NumericUpDown nudQuantity;
        private Label lblTotal;
        private Label label3;
    }
}
