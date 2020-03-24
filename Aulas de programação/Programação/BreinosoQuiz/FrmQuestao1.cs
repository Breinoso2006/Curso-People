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
    public partial class FrmQuestao1 : Form
    {
        public FrmQuestao1()
        {
            InitializeComponent();
            
        }

        private void FrmQuestao1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e) //ao apertar este botão, segue para a próxima questão
        {
            FrmQuestao3 f = new FrmQuestao3();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //ao apertar qualquer um dos outros, vai para a tela de Game Over
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }
    }
}
