using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios
{
    public partial class FrmPrincipal : Form
    {

        public List<TUsuario> listagem = new List<TUsuario>();
        public int indice = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            FrmCadUsuario f = new FrmCadUsuario(this);
            f.Show();
        }

        private void MenuListagem_Click(object sender, EventArgs e)
        {
            FrmList f2 = new FrmList(listagem);
            f2.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
