namespace Shop_Gregoricchio.CRUD_Form
{
    partial class ShowAll
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
            this.rdbClient = new System.Windows.Forms.RadioButton();
            this.rdbCategory = new System.Windows.Forms.RadioButton();
            this.rdbProduct = new System.Windows.Forms.RadioButton();
            this.rdbOrder = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbClient
            // 
            this.rdbClient.AutoSize = true;
            this.rdbClient.Location = new System.Drawing.Point(444, 28);
            this.rdbClient.Name = "rdbClient";
            this.rdbClient.Size = new System.Drawing.Size(51, 17);
            this.rdbClient.TabIndex = 11;
            this.rdbClient.TabStop = true;
            this.rdbClient.Text = "Client";
            this.rdbClient.UseVisualStyleBackColor = true;
            // 
            // rdbCategory
            // 
            this.rdbCategory.AutoSize = true;
            this.rdbCategory.Location = new System.Drawing.Point(53, 28);
            this.rdbCategory.Name = "rdbCategory";
            this.rdbCategory.Size = new System.Drawing.Size(67, 17);
            this.rdbCategory.TabIndex = 10;
            this.rdbCategory.TabStop = true;
            this.rdbCategory.Text = "Category";
            this.rdbCategory.UseVisualStyleBackColor = true;
            // 
            // rdbProduct
            // 
            this.rdbProduct.AutoSize = true;
            this.rdbProduct.Location = new System.Drawing.Point(176, 28);
            this.rdbProduct.Name = "rdbProduct";
            this.rdbProduct.Size = new System.Drawing.Size(62, 17);
            this.rdbProduct.TabIndex = 9;
            this.rdbProduct.TabStop = true;
            this.rdbProduct.Text = "Product";
            this.rdbProduct.UseVisualStyleBackColor = true;
            // 
            // rdbOrder
            // 
            this.rdbOrder.AutoSize = true;
            this.rdbOrder.Location = new System.Drawing.Point(319, 28);
            this.rdbOrder.Name = "rdbOrder";
            this.rdbOrder.Size = new System.Drawing.Size(51, 17);
            this.rdbOrder.TabIndex = 8;
            this.rdbOrder.TabStop = true;
            this.rdbOrder.Text = "Order";
            this.rdbOrder.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 297);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbProduct);
            this.groupBox1.Controls.Add(this.rdbClient);
            this.groupBox1.Controls.Add(this.rdbCategory);
            this.groupBox1.Controls.Add(this.rdbOrder);
            this.groupBox1.Location = new System.Drawing.Point(97, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(548, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "ShowAll";
            this.Text = "ShowAll";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbClient;
        private System.Windows.Forms.RadioButton rdbCategory;
        private System.Windows.Forms.RadioButton rdbProduct;
        private System.Windows.Forms.RadioButton rdbOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}