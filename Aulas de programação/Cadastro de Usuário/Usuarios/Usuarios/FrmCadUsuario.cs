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
    public partial class FrmCadUsuario : Form
    {
        public FrmPrincipal fp;

        public FrmCadUsuario(FrmPrincipal p)
        {
            InitializeComponent();
            fp = p;
        }

        private void RbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMasculino.Checked == true)
            {
                RbFeminino.Checked = false;
            }
        }

        private void RbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (RbFeminino.Checked == true)
            {
                RbMasculino.Checked = false;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TUsuario u = new TUsuario();
            u.SetNome(TbNome.Text);
            u.SetEndereco(TbEndereco.Text);
            u.SetNivel(int.Parse(TbNivel.Text));
            u.SetNascimento(DtpNascimento.Value);
            u.SetId(fp.indice);
            fp.indice++;
            if (RbMasculino.Checked == true)
            {
                u.SetSexo('M');
            }
            else
            {
                u.SetSexo('F');
            }
            MessageBox.Show("Usuário Cadastrado com sucesso!\nNome: " + u.GetNome() + "\nNível: " + u.GetNivel() + "\nEndereço: " + u.GetEndereco() + "\nNascimento: " + u.GetNascimento().ToString() + "\nSexo: " + u.GetSexo());
            fp.listagem.Add(u);
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TbNome.Text = "";
            TbEndereco.Text = "";
            TbNivel.Text = "";
            RbFeminino.Checked = false;
            RbMasculino.Checked = false;
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {

        }

        private void TbNome_TextChanged(object sender, EventArgs e)
        {
            if (TbNome.Text == "")
            {
                TbNome.BackColor = Color.Red;
            }
            else
            {
                TbNome.BackColor = Color.Green;
            }
        }

        private void TbNivel_TextChanged(object sender, EventArgs e)
        {
            if (TbNivel.Text == "")
            {
                TbNivel.BackColor = Color.Red;
            }
            else
            {
                TbNivel.BackColor = Color.Green;
            }
        }

        private void TbEndereco_TextChanged(object sender, EventArgs e)
        {
            if (TbEndereco.Text == "")
            {
                TbEndereco.BackColor = Color.Red;
            }
            else
            {
                TbEndereco.BackColor = Color.Green;
            }
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
