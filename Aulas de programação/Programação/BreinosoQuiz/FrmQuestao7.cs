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
    public partial class FrmQuestao7 : Form
    {
        public FrmQuestao7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmGameOver f = new FrmGameOver();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmQuestao8 f = new FrmQuestao8();
            f.Show();
            this.Close();
        }
    }
}
