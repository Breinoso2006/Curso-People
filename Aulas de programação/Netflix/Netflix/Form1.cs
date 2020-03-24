using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Netflix
{
    public partial class FrmPrincipal : Form
    {
        public List<TFilme> listagem = new List<TFilme> ();
                      
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro f = new FrmCadastro(this);
            f.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
