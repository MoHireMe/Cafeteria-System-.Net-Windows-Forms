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
            CmbCaterory = new ComboBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView2 = new DataGridView();
            btnCheckout = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // CmbCaterory
            // 
            CmbCaterory.BackColor = SystemColors.ControlLightLight;
            CmbCaterory.ForeColor = Color.DarkRed;
            CmbCaterory.FormattingEnabled = true;
            CmbCaterory.Location = new Point(366, 66);
            CmbCaterory.Name = "CmbCaterory";
            CmbCaterory.Size = new Size(369, 33);
            CmbCaterory.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(893, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 397);
            dataGridView1.TabIndex = 2;
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
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(588, 626);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 68);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete from order";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.RosyBrown;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(45, 132);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(707, 454);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
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
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(287, 646);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(152, 31);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(893, 571);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 8;
            label1.Text = "Checkout";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Snow;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(78, 67);
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
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnCheckout);
            Controls.Add(dataGridView2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(CmbCaterory);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbCaterory;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridView2;
        private Button btnCheckout;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label3;
    }
}
