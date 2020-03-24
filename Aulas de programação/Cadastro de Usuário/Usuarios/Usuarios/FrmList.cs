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
    public partial class FrmList : Form
    {
        private List<TUsuario> usuarios;

        public int indice = 0;

        public FrmList(List<TUsuario> u)
        {
            InitializeComponent();
            usuarios = u;
            Exibe();
        }
        public void Exibe()
        {
            LblNome.Text = "Nome: " + usuarios[indice].nome;
            LblEndereco.Text = "Endereço: " + usuarios[indice].endereco;
            LblNascimento.Text = "Nascimento: " + usuarios[indice].nascimento.ToString();
            LblNivel.Text = "Nível: " + usuarios[indice].nivel.ToString();
            LblSexo.Text = "Sexo: " + usuarios[indice].sexo.ToString();
            int i = indice + 1;
            LblIndice.Text = i.ToString();
            LblId.Text = "ID: " + usuarios[indice].id.ToString();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (indice - 1 < 0)
            {

            }
            else
            {
                indice--;
                Exibe();
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (indice + 1 >= usuarios.Count())
            {

            }
            else
            {
                indice++;
                Exibe();
            }
        }
    }
}
