namespace AppExemploMenu
{
    partial class FrmVermelho
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
            this.menuStrip1.TabIndex = 2;
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
            // FrmVermelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmVermelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVermelho";
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