namespace Shop_Gregoricchio.CRUD_Form
{
    partial class ProductsToOrder
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNewProd = new System.Windows.Forms.ComboBox();
            this.btnNewProd = new System.Windows.Forms.Button();
            this.txtNewProd = new System.Windows.Forms.TextBox();
            this.txtModProd = new System.Windows.Forms.TextBox();
            this.btnModProd = new System.Windows.Forms.Button();
            this.cbxModProd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.cbxDelProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(675, 237);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            // 
            // cbxNewProd
            // 
            this.cbxNewProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewProd.FormattingEnabled = true;
            this.cbxNewProd.Location = new System.Drawing.Point(56, 97);
            this.cbxNewProd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNewProd.Name = "cbxNewProd";
            this.cbxNewProd.Size = new System.Drawing.Size(275, 24);
            this.cbxNewProd.TabIndex = 2;
            // 
            // btnNewProd
            // 
            this.btnNewProd.Location = new System.Drawing.Point(133, 207);
            this.btnNewProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewProd.Name = "btnNewProd";
            this.btnNewProd.Size = new System.Drawing.Size(123, 44);
            this.btnNewProd.TabIndex = 3;
            this.btnNewProd.Text = "Send";
            this.btnNewProd.UseVisualStyleBackColor = true;
            this.btnNewProd.Click += new System.EventHandler(this.btnNewProd_Click);
            // 
            // txtNewProd
            // 
            this.txtNewProd.Location = new System.Drawing.Point(56, 146);
            this.txtNewProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewProd.Name = "txtNewProd";
            this.txtNewProd.Size = new System.Drawing.Size(275, 22);
            this.txtNewProd.TabIndex = 4;
            // 
            // txtModProd
            // 
            this.txtModProd.Enabled = false;
            this.txtModProd.Location = new System.Drawing.Point(386, 146);
            this.txtModProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtModProd.Name = "txtModProd";
            this.txtModProd.Size = new System.Drawing.Size(275, 22);
            this.txtModProd.TabIndex = 8;
            // 
            // btnModProd
            // 
            this.btnModProd.Enabled = false;
            this.btnModProd.Location = new System.Drawing.Point(463, 207);
            this.btnModProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnModProd.Name = "btnModProd";
            this.btnModProd.Size = new System.Drawing.Size(123, 44);
            this.btnModProd.TabIndex = 7;
            this.btnModProd.Text = "Send";
            this.btnModProd.UseVisualStyleBackColor = true;
            this.btnModProd.Click += new System.EventHandler(this.btnModProd_Click);
            // 
            // cbxModProd
            // 
            this.cbxModProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModProd.Enabled = false;
            this.cbxModProd.FormattingEnabled = true;
            this.cbxModProd.Location = new System.Drawing.Point(386, 97);
            this.cbxModProd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxModProd.Name = "cbxModProd";
            this.cbxModProd.Size = new System.Drawing.Size(275, 24);
            this.cbxModProd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modify Product";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(768, 207);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(123, 44);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Send";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cbxDelProd
            // 
            this.cbxDelProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDelProd.FormattingEnabled = true;
            this.cbxDelProd.Location = new System.Drawing.Point(691, 97);
            this.cbxDelProd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDelProd.Name = "cbxDelProd";
            this.cbxDelProd.Size = new System.Drawing.Size(275, 24);
            this.cbxDelProd.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delete Product";
            // 
            // ProductsToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 590);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cbxDelProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModProd);
            this.Controls.Add(this.btnModProd);
            this.Controls.Add(this.cbxModProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewProd);
            this.Controls.Add(this.btnNewProd);
            this.Controls.Add(this.cbxNewProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsToOrder";
            this.Text = "ProductsToOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsToOrder_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNewProd;
        private System.Windows.Forms.Button btnNewProd;
        private System.Windows.Forms.TextBox txtNewProd;
        private System.Windows.Forms.TextBox txtModProd;
        private System.Windows.Forms.Button btnModProd;
        private System.Windows.Forms.ComboBox cbxModProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cbxDelProd;
        private System.Windows.Forms.Label label3;
    }
}