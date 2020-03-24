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
    public partial class FrmQuestao14 : Form
    {
        public FrmQuestao14()
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
            FrmParabens f = new FrmParabens();
            f.Show();
            this.Close();
        }
    }
}
