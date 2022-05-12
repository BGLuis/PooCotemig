namespace AppExemploMenu
{
    partial class FrmAzul
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulhariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormulhariosAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.FormulhariosVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.FormulhariosVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulhariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulhariosToolStripMenuItem
            // 
            this.formulhariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormulhariosAzul,
            this.FormulhariosVermelho,
            this.FormulhariosVerde});
            this.formulhariosToolStripMenuItem.Name = "formulhariosToolStripMenuItem";
            this.formulhariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.formulhariosToolStripMenuItem.Text = "Formulários";
            this.formulhariosToolStripMenuItem.Click += new System.EventHandler(this.formulhariosToolStripMenuItem_Click);
            // 
            // FormulhariosAzul
            // 
            this.FormulhariosAzul.Name = "FormulhariosAzul";
            this.FormulhariosAzul.Size = new System.Drawing.Size(180, 22);
            this.FormulhariosAzul.Text = "Azul";
            this.FormulhariosAzul.Click += new System.EventHandler(this.FormulhariosAzul_Click);
            // 
            // FormulhariosVermelho
            // 
            this.FormulhariosVermelho.Name = "FormulhariosVermelho";
            this.FormulhariosVermelho.Size = new System.Drawing.Size(180, 22);
            this.FormulhariosVermelho.Text = "Vermelho";
            this.FormulhariosVermelho.Click += new System.EventHandler(this.FormulhariosVermelho_Click);
            // 
            // FormulhariosVerde
            // 
            this.FormulhariosVerde.Name = "FormulhariosVerde";
            this.FormulhariosVerde.Size = new System.Drawing.Size(180, 22);
            this.FormulhariosVerde.Text = "Verde";
            this.FormulhariosVerde.Click += new System.EventHandler(this.FormulhariosVerde_Click);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAzul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulhariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormulhariosAzul;
        private System.Windows.Forms.ToolStripMenuItem FormulhariosVermelho;
        private System.Windows.Forms.ToolStripMenuItem FormulhariosVerde;
    }
}

