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
    public partial class Lista : Form
    {
        private List<TFilme> filmes;
        public int indice = 0;

        public Lista(List<TFilme> f)
        {
            InitializeComponent();
            filmes = f;
            Exibe();
        }

        private void Lista_Load(object sender, EventArgs e)
        {

        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (indice + 1 >= filmes.Count())
            {

            }
            else
            {
                indice++;
                Exibe();
            }
        }

        public void Exibe ()
        {
            LblNome.Text = "Nome: " + filmes[indice].nome;
            LblSinopse.Text = "Sinopse: " + filmes[indice].sinopse;
            LblClassificacao.Text = "Classificação: " + filmes[indice].classificacao + " anos.";
            LblDuracao.Text = "Duração: " + filmes[indice].duracao / 60 + " hora(s) e " + filmes[indice].duracao % 60 + " minutos.";
            LblGenero.Text = "Genero: " + filmes[indice].genero;
            LblId.Text = "ID: " + filmes[indice].id.ToString();       
            LblLancamento.Text = "Ano de lançamento: " + filmes[indice].lancamento;
            if (filmes[indice].lancamento == 2017)
            {
                this.BackColor = Color.LightGreen;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void BtnAnterior_Click_1(object sender, EventArgs e)
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
