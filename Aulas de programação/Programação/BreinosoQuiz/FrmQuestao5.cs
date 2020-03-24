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
    public partial class FrmQuestao5 : Form
    {
        public FrmQuestao5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQuestao6 f = new FrmQuestao6();
            f.Show();
            this.Close();
        }
    }
}
