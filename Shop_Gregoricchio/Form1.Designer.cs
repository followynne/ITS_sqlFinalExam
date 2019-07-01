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
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDettaglio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipale.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipale
            // 
            this.mnuPrincipale.AllowItemReorder = true;
            this.mnuPrincipale.BackColor = System.Drawing.SystemColors.Info;
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
            this.mnuPrincipale.Size = new System.Drawing.Size(818, 28);
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
            this.tsiNewOrdine.Size = new System.Drawing.Size(216, 26);
            this.tsiNewOrdine.Text = "Ordine";
            this.tsiNewOrdine.Click += new System.EventHandler(this.tsiNewOrdine_Click);
            // 
            // tsiNewCliente
            // 
            this.tsiNewCliente.Name = "tsiNewCliente";
            this.tsiNewCliente.Size = new System.Drawing.Size(216, 26);
            this.tsiNewCliente.Text = "Cliente";
            // 
            // tsiNewProdotto
            // 
            this.tsiNewProdotto.Name = "tsiNewProdotto";
            this.tsiNewProdotto.Size = new System.Drawing.Size(216, 26);
            this.tsiNewProdotto.Text = "Prodotto";
            // 
            // tsiNewCategoria
            // 
            this.tsiNewCategoria.Name = "tsiNewCategoria";
            this.tsiNewCategoria.Size = new System.Drawing.Size(216, 26);
            this.tsiNewCategoria.Text = "Categoria";
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
            this.tsiUpdOrdine.Size = new System.Drawing.Size(216, 26);
            this.tsiUpdOrdine.Text = "Ordine";
            // 
            // tsiUpdCliente
            // 
            this.tsiUpdCliente.Name = "tsiUpdCliente";
            this.tsiUpdCliente.Size = new System.Drawing.Size(216, 26);
            this.tsiUpdCliente.Text = "Cliente";
            // 
            // tsiUpdProdotto
            // 
            this.tsiUpdProdotto.Name = "tsiUpdProdotto";
            this.tsiUpdProdotto.Size = new System.Drawing.Size(216, 26);
            this.tsiUpdProdotto.Text = "Prodotto";
            // 
            // tsiUpdCategoria
            // 
            this.tsiUpdCategoria.Name = "tsiUpdCategoria";
            this.tsiUpdCategoria.Size = new System.Drawing.Size(216, 26);
            this.tsiUpdCategoria.Text = "Categoria";
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem2.Text = "Ordine";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem9.Text = "Cliente";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem10.Text = "Prodotto";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem11.Text = "Categoria";
            // 
            // tsmElenco
            // 
            this.tsmElenco.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.tsmElenco.Name = "tsmElenco";
            this.tsmElenco.Size = new System.Drawing.Size(135, 24);
            this.tsmElenco.Text = "Elenco Completo";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem6.Text = "Ordine";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem12.Text = "Cliente";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem13.Text = "Prodotto";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem14.Text = "Categoria";
            // 
            // tsmDettaglio
            // 
            this.tsmDettaglio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.tsmDettaglio.Name = "tsmDettaglio";
            this.tsmDettaglio.Size = new System.Drawing.Size(102, 24);
            this.tsmDettaglio.Text = "Al Dettaglio";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem7.Text = "Ordine";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem15.Text = "Cliente";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem16.Text = "Prodotto";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem17.Text = "Categoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.mnuPrincipale);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
    }
}

