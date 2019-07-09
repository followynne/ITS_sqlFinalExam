namespace Shop_Gregoricchio
{
    partial class Form1
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
            this.mnuPrincipale = new System.Windows.Forms.MenuStrip();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNewOrdine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNewCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNewProdotto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNewCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdOrdine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdProdotto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUpdCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmElenco = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDettaglio = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuPrincipale.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipale
            // 
            this.mnuPrincipale.AllowItemReorder = true;
            this.mnuPrincipale.BackColor = System.Drawing.Color.MintCream;
            this.mnuPrincipale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnuPrincipale.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNew,
            this.tsmUpdate,
            this.tsmDelete,
            this.tsmElenco,
            this.tsmDettaglio});
            this.mnuPrincipale.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipale.Name = "mnuPrincipale";
            this.mnuPrincipale.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuPrincipale.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuPrincipale.Size = new System.Drawing.Size(913, 28);
            this.mnuPrincipale.TabIndex = 0;
            this.mnuPrincipale.Text = "Menù Principale";
            // 
            // tsmNew
            // 
            this.tsmNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiNewOrdine,
            this.tsiNewCliente,
            this.tsiNewProdotto,
            this.tsiNewCategoria});
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.Size = new System.Drawing.Size(51, 24);
            this.tsmNew.Text = "New";
            // 
            // tsiNewOrdine
            // 
            this.tsiNewOrdine.Name = "tsiNewOrdine";
            this.tsiNewOrdine.Size = new System.Drawing.Size(149, 26);
            this.tsiNewOrdine.Text = "Ordine";
            this.tsiNewOrdine.Click += new System.EventHandler(this.tsiNewOrdine_Click);
            // 
            // tsiNewCliente
            // 
            this.tsiNewCliente.Name = "tsiNewCliente";
            this.tsiNewCliente.Size = new System.Drawing.Size(149, 26);
            this.tsiNewCliente.Text = "Cliente";
            this.tsiNewCliente.Click += new System.EventHandler(this.tsiNewCliente_Click);
            // 
            // tsiNewProdotto
            // 
            this.tsiNewProdotto.Name = "tsiNewProdotto";
            this.tsiNewProdotto.Size = new System.Drawing.Size(149, 26);
            this.tsiNewProdotto.Text = "Prodotto";
            this.tsiNewProdotto.Click += new System.EventHandler(this.tsiNewProdotto_Click);
            // 
            // tsiNewCategoria
            // 
            this.tsiNewCategoria.Name = "tsiNewCategoria";
            this.tsiNewCategoria.Size = new System.Drawing.Size(149, 26);
            this.tsiNewCategoria.Text = "Categoria";
            this.tsiNewCategoria.Click += new System.EventHandler(this.tsiNewCategoria_Click);
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUpdOrdine,
            this.tsiUpdCliente,
            this.tsiUpdProdotto,
            this.tsiUpdCategoria});
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Size = new System.Drawing.Size(70, 24);
            this.tsmUpdate.Text = "Update";
            // 
            // tsiUpdOrdine
            // 
            this.tsiUpdOrdine.Name = "tsiUpdOrdine";
            this.tsiUpdOrdine.Size = new System.Drawing.Size(149, 26);
            this.tsiUpdOrdine.Text = "Ordine";
            this.tsiUpdOrdine.Click += new System.EventHandler(this.tsiUpdOrdine_Click);
            // 
            // tsiUpdCliente
            // 
            this.tsiUpdCliente.Name = "tsiUpdCliente";
            this.tsiUpdCliente.Size = new System.Drawing.Size(149, 26);
            this.tsiUpdCliente.Text = "Cliente";
            this.tsiUpdCliente.Click += new System.EventHandler(this.tsiUpdCliente_Click);
            // 
            // tsiUpdProdotto
            // 
            this.tsiUpdProdotto.Name = "tsiUpdProdotto";
            this.tsiUpdProdotto.Size = new System.Drawing.Size(149, 26);
            this.tsiUpdProdotto.Text = "Prodotto";
            this.tsiUpdProdotto.Click += new System.EventHandler(this.tsiUpdProdotto_Click);
            // 
            // tsiUpdCategoria
            // 
            this.tsiUpdCategoria.Name = "tsiUpdCategoria";
            this.tsiUpdCategoria.Size = new System.Drawing.Size(149, 26);
            this.tsiUpdCategoria.Text = "Categoria";
            this.tsiUpdCategoria.Click += new System.EventHandler(this.tsiUpdCategoria_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(65, 24);
            this.tsmDelete.Text = "Delete";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItem2.Text = "Ordine";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItem9.Text = "Cliente";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItem10.Text = "Prodotto";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(149, 26);
            this.toolStripMenuItem11.Text = "Categoria";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // tsmElenco
            // 
            this.tsmElenco.Name = "tsmElenco";
            this.tsmElenco.Size = new System.Drawing.Size(135, 24);
            this.tsmElenco.Text = "Elenco Completo";
            this.tsmElenco.Click += new System.EventHandler(this.tsmElenco_Click);
            // 
            // tsmDettaglio
            // 
            this.tsmDettaglio.Name = "tsmDettaglio";
            this.tsmDettaglio.Size = new System.Drawing.Size(102, 24);
            this.tsmDettaglio.Text = "Al Dettaglio";
            this.tsmDettaglio.Click += new System.EventHandler(this.tsmDettaglio_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(69, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(741, 426);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mnuPrincipale);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mnuPrincipale.ResumeLayout(false);
            this.mnuPrincipale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipale;
        private System.Windows.Forms.ToolStripMenuItem tsmNew;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmElenco;
        private System.Windows.Forms.ToolStripMenuItem tsmDettaglio;
        private System.Windows.Forms.ToolStripMenuItem tsiNewCliente;
        private System.Windows.Forms.ToolStripMenuItem tsiNewCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsiNewProdotto;
        private System.Windows.Forms.ToolStripMenuItem tsiNewOrdine;
        private System.Windows.Forms.ToolStripMenuItem tsiUpdOrdine;
        private System.Windows.Forms.ToolStripMenuItem tsiUpdCliente;
        private System.Windows.Forms.ToolStripMenuItem tsiUpdProdotto;
        private System.Windows.Forms.ToolStripMenuItem tsiUpdCategoria;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

