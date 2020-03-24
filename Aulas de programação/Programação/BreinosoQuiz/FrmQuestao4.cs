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
    public partial class FrmQuestao4 : Form
    {
        public FrmQuestao4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmQuestao5 f = new FrmQuestao5();
            f.Show();
            this.Close();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
        }

        private void panel1_MouseEnter(object sender, EventArgs e) //ao passar o mouse sobre o painel, o botão fica visível
        {
            button5.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
