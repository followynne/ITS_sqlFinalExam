namespace Shop_Gregoricchio.CRUD_Form
{
    partial class NewOrder
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxPagamento = new System.Windows.Forms.ComboBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "CREATE ORDER";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(245, 402);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(169, 43);
            this.btnSend.TabIndex = 34;
            this.btnSend.Text = "CREATE";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownHeight = 200;
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.IntegralHeight = false;
            this.cbxCliente.Location = new System.Drawing.Point(293, 84);
            this.cbxCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(295, 24);
            this.cbxCliente.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pagamento";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(168, 135);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(38, 17);
            this.Data.TabIndex = 24;
            this.Data.Text = "Data";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(293, 129);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(295, 22);
            this.dtpDate.TabIndex = 36;
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPagamento.FormattingEnabled = true;
            this.cbxPagamento.Location = new System.Drawing.Point(292, 190);
            this.cbxPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(295, 24);
            this.cbxPagamento.TabIndex = 37;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(293, 244);
            this.txtShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(372, 126);
            this.txtShow.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "AggiungiProdotti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Prodotti";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.cbxPagamento);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Data);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxPagamento;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}