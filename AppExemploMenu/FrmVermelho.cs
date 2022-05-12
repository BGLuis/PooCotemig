using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmVermelho : Form
    {
        public FrmVermelho()
        {
            InitializeComponent();
        }

        private void FormulhariosAzul_Click(object sender, EventArgs e)
        {
            FrmAzul FrmAzul = new FrmAzul();
            this.Hide();
            FrmAzul.ShowDialog();
        }

        private void FormulhariosVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho FrmVermelho = new FrmVermelho();
            this.Hide();
            FrmVermelho.ShowDialog();
        }

        private void FormulhariosVerde_Click(object sender, EventArgs e)
        {
            FrmVerde FrmVerde = new FrmVerde();
            this.Hide();
            FrmVerde.ShowDialog();
        }
    }
}
