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
    public partial class FrmQuestao9 : Form
    {
        public FrmQuestao9()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQuestao10 f = new FrmQuestao10();
            f.Show();
            this.Close();
        }
    }
}
