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
    public partial class FrmQuestao12 : Form
    {
        public FrmQuestao12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmQuestao13 f = new FrmQuestao13();
            f.Show();
            this.Close();
        }
    }
}
