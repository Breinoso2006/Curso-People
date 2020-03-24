using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreinosoQuiz
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e) // ao apertar o botao, aparece a primeira questão
        {
            FrmQuestao1 f = new FrmQuestao1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e) // ao apertar o botao, fecha o programa
        {
            this.Close();
        }
    }
}
