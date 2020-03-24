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
    public partial class FrmQuestao3 : Form
    {
        public FrmQuestao3()
        {
            InitializeComponent();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGray;
        }

        private void button2_Move(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.ForestGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQuestao2 f = new FrmQuestao2();
            f.Show();
            this.Close();
        }
    }
}
