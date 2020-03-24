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
    public partial class FrmQuestao2 : Form
    {
        public FrmQuestao2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmQuestao4 f = new FrmQuestao4();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }
    }
}
