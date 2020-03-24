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
    public partial class FrmCadastro : Form
    {
        FrmPrincipal fp;
        
        public FrmCadastro(FrmPrincipal p)

        {
            InitializeComponent();
            fp = p;

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TbNome.Text = "";
            TbSinopse.Text = "";
            TbLancamento.Text = "";
            TbDuracao.Value = 0;
            TbDuracao.Value = 0;
            LblDuracao.Text = "Duração: ";
            CbAcao.Checked = false;
            CbAventura.Checked = false;
            CbComedia.Checked = false;
            CbRomance.Checked = false;
            CbSuspense.Checked = false;
            CbTerror.Checked = false;            
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TFilme f = new TFilme();
            f.SetNome(TbNome.Text);
            f.SetLancamento(int.Parse(TbLancamento.Text));
            f.SetClassificacao(int.Parse(CbClassificacao.Text));
            f.SetDuracao(TbDuracao.Value);
            f.SetSinopse(TbSinopse.Text);
            String genero = "";

            if (CbAcao.Checked == true)
            {
                genero += "Ação; ";
            }
            if (CbAventura.Checked == true)
            {
                genero += "Aventura; ";
            }
            if (CbComedia.Checked == true)
            {
                genero += "Comédia; ";
            }
            if (CbRomance.Checked == true)
            {
                genero += "Romance; ";
            }
            if (CbSuspense.Checked == true)
            {
                genero += "Suspense; ";
            }
            if (CbTerror.Checked == true)
            {
                genero += "Terror; ";
            }

            f.SetGenero(genero);
            f.SetId(fp.indice);
            fp.listagem.Add(f);
            fp.indice++;
            this.Close();
        }

        private void TbDuracao_Scroll(object sender, EventArgs e)
        {
            LblDuracao.Text = "Duração: " + TbDuracao.Value / 60 + " horas e " + TbDuracao.Value % 60 + " minutos.";
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

        private void TbSinopse_TextChanged(object sender, EventArgs e)
        {
            if (TbSinopse.Text == "")
            {
                TbSinopse.BackColor = Color.Red;
            }
            else
            {
                TbSinopse.BackColor = Color.Green;
            }
        }

        private void TbLancamento_TextChanged(object sender, EventArgs e)
        {
            if (TbLancamento.Text == "")
            {
                TbLancamento. BackColor = Color.Red;
            }
            else
            {
                TbLancamento.BackColor = Color.Green;
            }

            if (TbLancamento.Text == "")
            {
                TbLancamento.Text = "0";
            }

            if (int.Parse(TbLancamento.Text) < 1900)

            {
                TbLancamento.BackColor = Color.Red;
            }

            if (int.Parse(TbLancamento.Text) > 2017)
            {
                TbLancamento.BackColor = Color.Red;
            }
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void TbLancamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
