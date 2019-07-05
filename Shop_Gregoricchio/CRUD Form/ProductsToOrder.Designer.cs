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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 236);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 193);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            // 
            // cbxNewProd
            // 
            this.cbxNewProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewProd.FormattingEnabled = true;
            this.cbxNewProd.Location = new System.Drawing.Point(98, 79);
            this.cbxNewProd.Name = "cbxNewProd";
            this.cbxNewProd.Size = new System.Drawing.Size(207, 21);
            this.cbxNewProd.TabIndex = 2;
            // 
            // btnNewProd
            // 
            this.btnNewProd.Location = new System.Drawing.Point(156, 168);
            this.btnNewProd.Name = "btnNewProd";
            this.btnNewProd.Size = new System.Drawing.Size(92, 36);
            this.btnNewProd.TabIndex = 3;
            this.btnNewProd.Text = "Send";
            this.btnNewProd.UseVisualStyleBackColor = true;
            // 
            // txtNewProd
            // 
            this.txtNewProd.Location = new System.Drawing.Point(98, 127);
            this.txtNewProd.Name = "txtNewProd";
            this.txtNewProd.Size = new System.Drawing.Size(207, 20);
            this.txtNewProd.TabIndex = 4;
            // 
            // txtModProd
            // 
            this.txtModProd.Enabled = false;
            this.txtModProd.Location = new System.Drawing.Point(405, 127);
            this.txtModProd.Name = "txtModProd";
            this.txtModProd.Size = new System.Drawing.Size(207, 20);
            this.txtModProd.TabIndex = 8;
            // 
            // btnModProd
            // 
            this.btnModProd.Enabled = false;
            this.btnModProd.Location = new System.Drawing.Point(463, 168);
            this.btnModProd.Name = "btnModProd";
            this.btnModProd.Size = new System.Drawing.Size(92, 36);
            this.btnModProd.TabIndex = 7;
            this.btnModProd.Text = "Send";
            this.btnModProd.UseVisualStyleBackColor = true;
            // 
            // cbxModProd
            // 
            this.cbxModProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModProd.Enabled = false;
            this.cbxModProd.FormattingEnabled = true;
            this.cbxModProd.Location = new System.Drawing.Point(405, 79);
            this.cbxModProd.Name = "cbxModProd";
            this.cbxModProd.Size = new System.Drawing.Size(207, 21);
            this.cbxModProd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modify Product";
            // 
            // ProductsToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 479);
            this.Controls.Add(this.txtModProd);
            this.Controls.Add(this.btnModProd);
            this.Controls.Add(this.cbxModProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewProd);
            this.Controls.Add(this.btnNewProd);
            this.Controls.Add(this.cbxNewProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ProductsToOrder";
            this.Text = "ProductsToOrder";
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
    }
}