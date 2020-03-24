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
    public partial class FrmQuestao8 : Form
    {
        public FrmQuestao8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmQuestao9 f = new FrmQuestao9();
            f.Show();
            this.Close();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
