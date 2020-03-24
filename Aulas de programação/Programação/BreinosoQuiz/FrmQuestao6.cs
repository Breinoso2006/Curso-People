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
    public partial class FrmQuestao6 : Form
    {
        public FrmQuestao6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmQuestao7 f = new FrmQuestao7();
            f.Show();
            this.Close();
        }
    }
}
